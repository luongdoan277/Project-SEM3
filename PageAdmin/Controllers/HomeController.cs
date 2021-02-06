using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PageAdmin.Data;
using PageAdmin.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PageAdmin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly PageAdminContext _context;
        public HomeController(PageAdminContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = _context.Medias.OrderBy(m => m.ShopID).Include(m => m.Shops);
            return View(await model.ToListAsync());
        }
    }
}
