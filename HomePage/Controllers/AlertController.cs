using HomePage.Models;
using HomePage.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Controllers
{
    public class AlertController : Controller
    {
        private readonly IStoreRepository repository;
        private readonly StoreDbContext context;

        public AlertController(IStoreRepository repo, StoreDbContext _context)
        {
            context = _context;
            repository = repo;

        }
        public IActionResult Booking(int booking, int show)
        {
            ContentListViewModel model = new ContentListViewModel
            {
                Bookings = repository.Bookings.Where(b => b.BookingID == booking).Include(u => u.UserBooking),
                Shows = repository.Shows.Where(s =>s.ShowID== show).Include(s => s.Movie),
                ShowSeats = repository.ShowSeats.Where(b => b.BookingID == booking).Include(m => m.CinemaSeat)
            };
            return View(model);
        }
    }
}
