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
    public class FeedBackController : Controller
    {
        private readonly IStoreRepository repository;

        private readonly StoreDbContext context;

        public FeedBackController(StoreDbContext _context)
        {
            context = _context;
        }

        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string FullName,string Email,string Message,string NumberPhone,string Subject)
        {
            Feedback feedback = new Feedback
            {
                FullName = FullName,
                Email = Email,
                Message = Message,
                NumberPhone = NumberPhone,
                Subject = Subject,
                FeedbackDate = DateTime.Now
            };

            context.Add(feedback);
            context.SaveChanges();

            return View();
        }
    }
}
