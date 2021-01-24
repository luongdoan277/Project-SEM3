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
    public class CinemaHellsController : Controller
    {
        private readonly PageAdminContext _context;

        public CinemaHellsController(PageAdminContext context)
        {
            _context = context;
        }

        // GET: CinemaHells
        public async Task<IActionResult> Index()
        {
            return View(await _context.CinemaHells.ToListAsync());
        }

        // GET: CinemaHells/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinemaHell = await _context.CinemaHells
                .FirstOrDefaultAsync(m => m.CinemaHellID == id);
            if (cinemaHell == null)
            {
                return NotFound();
            }

            return View(cinemaHell);
        }

        // GET: CinemaHells/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CinemaHells/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CinemaHellID,Name,TotalSeats")] CinemaHell cinemaHell)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cinemaHell);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cinemaHell);
        }

        // GET: CinemaHells/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinemaHell = await _context.CinemaHells.FindAsync(id);
            if (cinemaHell == null)
            {
                return NotFound();
            }
            return View(cinemaHell);
        }

        // POST: CinemaHells/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CinemaHellID,Name,TotalSeats")] CinemaHell cinemaHell)
        {
            if (id != cinemaHell.CinemaHellID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cinemaHell);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CinemaHellExists(cinemaHell.CinemaHellID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cinemaHell);
        }

        // GET: CinemaHells/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cinemaHell = await _context.CinemaHells
                .FirstOrDefaultAsync(m => m.CinemaHellID == id);
            if (cinemaHell == null)
            {
                return NotFound();
            }

            return View(cinemaHell);
        }

        // POST: CinemaHells/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemaHell = await _context.CinemaHells.FindAsync(id);
            _context.CinemaHells.Remove(cinemaHell);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CinemaHellExists(int id)
        {
            return _context.CinemaHells.Any(e => e.CinemaHellID == id);
        }
    }
}
