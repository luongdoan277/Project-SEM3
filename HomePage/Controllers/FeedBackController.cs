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
        private IStoreRepository repository;

        private readonly StoreDbContext _context;

        public FeedBackController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback model)
        {
            var newFeedback = new Feedback()
            {
                FullName = model.FullName,
                Email = model.Email,
                Message = model.Message,
                NumberPhone = model.NumberPhone,
                Subject = model.Subject,
                FeedbackDate = DateTime.UtcNow
            };

            _context.Feedbacks.Add(newFeedback);
            _context.SaveChanges();

            return View(model);
        }
    }
}
