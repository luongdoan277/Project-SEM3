using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePage.Models;
using HomePage.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using HomePage.Infrastructure;
using Microsoft.Extensions.Configuration;
using PayPal.Core;
using PayPal.v1.Payments;
using BraintreeHttp;

namespace HomePage.Controllers
{
    public class PaymentTicketController : Controller
    {
        private readonly IStoreRepository repository;
        private readonly StoreDbContext context;
        public IConfiguration configuration { get; }

        public PaymentTicketController(IStoreRepository repo, StoreDbContext _context, IConfiguration _configuration)
        {
            context = _context;
            repository = repo;
            configuration = _configuration;

        }
        public IActionResult Index(int MovieID, int CinemaHallID, int ShowID)
        {
            ListSeat list = HttpContext.Session.GetJson<ListSeat>("ticket");
            int Basic = 0;
            int Vip = 0;
            int Couple = 0;
            decimal Price = 0;
            foreach (var seat in list.Items)
            {
                if (seat.Type == 1)
                {
                    Basic++;
                }
                if (seat.Type == 2)
                {
                    Vip++;
                }
                if (seat.Type == 3)
                {
                    Couple++;
                }
                Price = (decimal)(Basic * 7.36 + Vip * 9 + Couple * 10.25);
            }
            ContentListViewModel model = new ContentListViewModel
            {
                CinemaSeats = repository.CinemaSeats.OrderBy(m => m.CinemaSeatID)
                .Include(m => m.CinemaHall).Where(m => m.CinemaHallID == CinemaHallID),
                Medias = repository.Medias.OrderBy(m => m.MovieID).Include(m => m.Movies).Where(m => m.MovieID == MovieID),
                Shows = repository.Shows.OrderBy(m => m.CinemaHallID).Include(m => m.CinemaHall).Where(m => m.ShowID == ShowID),
                Price = Price,
                Basic = Basic,
                Vip = Vip,
                Couple = Couple,
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> checkoutTicket(string Name, string Email, int ShowID, double Price)
        {
            UserBooking user = new UserBooking
            {
                UserBookingName = Name,
                UserBookingEmail = Email
            };
            await context.UserBookings.AddAsync(user);
            await context.SaveChangesAsync();
            var list = HttpContext.Session.GetJson<ListSeat>("ticket");
            var i = list.Items.Count;
            Booking booking = new Booking
            {
                NumberOfSeat = i,
                Timestamp = DateTime.Now,
                Status = 0,
                UserBookingID = user.UserBookingID,
                ShowID = ShowID
            };
            await context.Bookings.AddAsync(booking);
            await context.SaveChangesAsync();
            string url = await PaypalPayment(Price);
            if (url != null)
            {
                booking.Status = 1;
                context.Update(booking);
                await context.SaveChangesAsync();
                HttpContext.Session.Remove("ticket");
            };
            decimal p = 0;
            foreach (var seat in list.Items)
            {
                if (seat.Type == 1)
                {
                    p = (decimal)7.36;
                }
                if (seat.Type == 2)
                {
                    p = (decimal)9;
                }
                if (seat.Type == 3)
                {
                    p = (decimal)10.25;
                }
                ShowSeat showSeat = new ShowSeat
                {
                    ShowID = ShowID,
                    BookingID = booking.BookingID,
                    Price = p,
                    CinemaSeatID = seat.CinemaSeatID,
                };
            }
            return Redirect(url);
        }
        public async Task<string> PaypalPayment(double total)
        {
            var environment = new SandboxEnvironment(configuration["PayPal:clientId"], configuration["PayPal:secret"]);
            var client = new PayPalHttpClient(environment);

            var payment = new PayPal.v1.Payments.Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = total.ToString(),
                            Currency = "USD"
                        }
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = configuration["PayPal:cancelUrl"],
                    ReturnUrl = configuration["PayPal:returnUrl"]
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);
            string paypalRedirectUrl = null;
            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                PayPal.v1.Payments.Payment result = response.Result<PayPal.v1.Payments.Payment>();
                var links = result.Links.GetEnumerator();
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment
                        paypalRedirectUrl = lnk.Href;
                    }
                }
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
            }
            return paypalRedirectUrl;
        }
    }
}
