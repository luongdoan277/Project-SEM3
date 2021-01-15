using HomePage.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPage.Controllers
{
    public class AuthController : Controller
    {
        private readonly StoreDbContext context;
        public AuthController(StoreDbContext _context)
        {
            context = _context;
        }
        [HttpGet, AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        //private 
    }
}
