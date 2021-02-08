using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePage.Models;
using HomePage.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HomePage.Controllers
{
    public class PaymentTicketController : Controller
    {
        private IStoreRepository repository;

        public PaymentTicketController(IStoreRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index(int MovieID, int CinemaHallID,int ShowID)
        {
            ContentListViewModel model = new ContentListViewModel
            {
                CinemaSeats = repository.CinemaSeats.OrderBy(m => m.CinemaSeatID)
                .Include(m => m.CinemaHall).Where(m => m.CinemaHallID == CinemaHallID),

                Medias = repository.Medias.OrderBy(m => m.MovieID).Include(m => m.Movies).Where(m => m.MovieID == MovieID),

                Shows = repository.Shows.OrderBy(m => m.CinemaHallID).Include(m => m.CinemaHall).Where(m => m.ShowID == ShowID)


            };
            return View(model);
        }
    }
}
