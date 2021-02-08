using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PageAdmin.Areas.Identity.Data;
using PageAdmin.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PageAdmin.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<PageAdminUser> _context;
        
        public AccountController(UserManager<PageAdminUser> context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var pageAdminContext = _context.Users;
            return View(await pageAdminContext.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string Email, string Password, string ConfirmPassword)
        {
            if (ModelState.IsValid)
            {
                if (Password == ConfirmPassword)
                {
                    var user = new PageAdminUser { UserName = Email, Email = Email };
                    var result = await _context.CreateAsync(user, Password);
                }
                else
                {
                    ViewBag.Message = string.Format("Password is invalid");
                    return RedirectToAction(nameof(Index));
                }
            }
            return View();
        }
        public async Task<ActionResult> Delete(string userId)
        {
            if (userId == null)
            {
                return NotFound();
            }

            //get User Data from Userid
            var user = await _context.FindByIdAsync(userId);

            //List Logins associated with user
            
            //Delete User
            await _context.DeleteAsync(user);

            ViewBag.Message = "User Deleted Successfully. ";
            return RedirectToAction(nameof(Index));
        }
    }
}
