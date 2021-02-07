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

        public ViewResult Index()
        {
            ContentListViewModel model = new ContentListViewModel
            {
                CinemaSeats = repository.CinemaSeats.OrderBy(m => m.CinemaHallID).Include(m => m.CinemaHall)
            };
            return View(model);
        }

    }
}
