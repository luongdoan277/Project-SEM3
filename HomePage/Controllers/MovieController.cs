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
    public class MovieController : Controller
    {
        private IStoreRepository repository;

        public MovieController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            ContentListViewModel model = new ContentListViewModel
            {
                //Movies = repository.Movies.OrderBy(m => m.MovieID)

                Medias = repository.Medias.Where(m => m.MovieID != null).OrderBy(m => m.MovieID).Include(m => m.Movies)
            };
            return View(model);
        }

        public ViewResult Detail(int MovieID,int ShowID)
        {
            return View(new ContentListViewModel
            {
                //Movies = repository.Movies.Where(p => p.MovieID == MovieID)

                Medias = repository.Medias
                .Include(s => s.Movies)
                .Where(m => m.MovieID == MovieID),

                Shows = repository.Shows.OrderBy(m => m.ShowID).Include(m => m.CinemaHall).Where(m => m.MovieID == MovieID)


            });
        }
    }
}
