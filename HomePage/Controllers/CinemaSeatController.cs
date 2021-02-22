using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePage.Models;
using HomePage.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using HomePage.Infrastructure;

namespace HomePage.Controllers
{
    public class CinemaSeatController : Controller
    {
        private readonly IStoreRepository repository;
        private readonly StoreDbContext context;
        //public int totalPrice = 0;
        public CinemaSeatController(IStoreRepository repo, StoreDbContext _context)
        {
            repository = repo;
            context = _context;
        }

        public ViewResult Index(int MovieID,int CinemaHallID,int ShowID)
        {
            ContentListViewModel model = new ContentListViewModel
            {
                CinemaSeats = repository.CinemaSeats.OrderBy(m => m.SeatNumber)
                .Include(m => m.CinemaHall).Where(m => m.CinemaHallID == CinemaHallID),

                Medias = repository.Medias.OrderBy(m => m.MovieID).Include(m => m.Movies).Where(m => m.MovieID == MovieID),

                Shows = repository.Shows.OrderBy(m => m.ShowID).Include(m => m.CinemaHall).Where(m => m.ShowID == ShowID),

            };
            return View(model);
        }


        public ListSeat ListSeat { get; set; }
        public IActionResult AddSeat(int Id)
        {
            CinemaSeat seat = context.CinemaSeats.Find(Id);
            ListSeat = HttpContext.Session.GetJson<ListSeat>("ticket") ?? new ListSeat();
            ListSeat.CheckboxAdd(seat);
            HttpContext.Session.SetJson("ticket", ListSeat);
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public IActionResult RemoveSeat(int Id)
        {
            CinemaSeat seat = context.CinemaSeats.Find(Id);
            ListSeat = HttpContext.Session.GetJson<ListSeat>("ticket") ?? new ListSeat();
            ListSeat.CheckboxRemove(seat);
            HttpContext.Session.SetJson("ticket", ListSeat);
            var ListSeat1 = HttpContext.Session.GetJson<ListSeat>("ticket");
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
