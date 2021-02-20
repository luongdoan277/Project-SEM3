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
    public class CinemaSeatController : Controller
    {
        private IStoreRepository repository;

        public CinemaSeatController(IStoreRepository repo)
        {
            repository = repo;
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




    }
}
