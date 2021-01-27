using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PageAdmin.Data;
using PageAdmin.Models;

namespace PageAdmin.Controllers
{
    public class FeedbacksController : Controller
    {
        private readonly PageAdminContext _context;

        public FeedbacksController(PageAdminContext context)
        {
            _context = context;
        }

        // GET: Feedbacks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Feedback.ToListAsync());
        }

        // GET: Feedbacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedback
                .FirstOrDefaultAsync(m => m.FeedbackID == id);
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }

        private bool FeedbackExists(int id)
        {
            return _context.Feedback.Any(e => e.FeedbackID == id);
        }
    }
}
