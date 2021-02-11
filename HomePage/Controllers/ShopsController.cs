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
    public class ShopsController : Controller
    {
        private IStoreRepository repository;

        public ShopsController(IStoreRepository repo)
        {
            repository = repo;
        }

        
        public ViewResult Index()
        {
            ContentListViewModel model = new ContentListViewModel
            {
                Medias = repository.Medias.Where(m => m.ShopID != null).OrderBy(m => m.ShopID).Include(m => m.Shops)
            };
            return View(model);
        }

        public ViewResult Detail(int ShopID)
        {
            ContentListViewModel model = new ContentListViewModel
            {
                Products = repository.Products
                .OrderBy(m => m.ShopID)
                .Include(s => s.Shops)
                .Where(m => m.ShopID == ShopID),


                Medias = repository.Medias.Where(m => m.ShopID != null).OrderBy(m => m.ShopID).Include(m => m.Shops)


                //Shops = repository.Shops
                //.Include(s => s.Categories)
                //.Where(m => m.ShopID == ShopID)
            };
            return View(model);
        }
    }
}
