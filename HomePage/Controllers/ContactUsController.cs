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
    public class ContactUsController : Controller
    {
        private readonly StoreDbContext context;

        public ContactUsController(StoreDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
