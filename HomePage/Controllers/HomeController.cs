using HomePage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HomePage.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HomePage.Controllers
{
    public class HomeController : Controller
    {

        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            ContentListViewModel model = new ContentListViewModel
            {
                Medias = repository.Medias.Where(m => m.ShopID != null).OrderBy(m => m.ShopID).Include(m => m.Shops)
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
