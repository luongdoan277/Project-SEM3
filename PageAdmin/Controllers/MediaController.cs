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
    public class MediaController : Controller
    {
        private readonly PageAdminContext _context;

        public MediaController(PageAdminContext context)
        {
            _context = context;
        }

        // GET: Media
        public async Task<IActionResult> Index()
        {
            var pageAdminContext = _context.Medias.Include(m => m.Movie).Include(m => m.Product).Include(m => m.Shops);
            return View(await pageAdminContext.ToListAsync());
        }

        // GET: Media/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var media = await _context.Medias
                .Include(m => m.Movie)
                .Include(m => m.Product)
                .Include(m => m.Shops)
                .FirstOrDefaultAsync(m => m.MediaID == id);
            if (media == null)
            {
                return NotFound();
            }

            return View(media);
        }

        // GET: Media/Create
        public IActionResult Create()
        {
            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "MovieID");
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductID");
            ViewData["ShopID"] = new SelectList(_context.Shops, "ShopID", "ShopID");
            return View();
        }

        // POST: Media/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MediaID,Url,ShopID,MovieID,ProductID")] Media media)
        {
            if (ModelState.IsValid)
            {
                _context.Add(media);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "MovieID", media.MovieID);
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductID", media.ProductID);
            ViewData["ShopID"] = new SelectList(_context.Shops, "ShopID", "ShopID", media.ShopID);
            return View(media);
        }

        // GET: Media/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var media = await _context.Medias.FindAsync(id);
            if (media == null)
            {
                return NotFound();
            }
            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "MovieID", media.MovieID);
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductID", media.ProductID);
            ViewData["ShopID"] = new SelectList(_context.Shops, "ShopID", "ShopID", media.ShopID);
            return View(media);
        }

        // POST: Media/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MediaID,Url,ShopID,MovieID,ProductID")] Media media)
        {
            if (id != media.MediaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(media);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MediaExists(media.MediaID))
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
            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "MovieID", media.MovieID);
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductID", media.ProductID);
            ViewData["ShopID"] = new SelectList(_context.Shops, "ShopID", "ShopID", media.ShopID);
            return View(media);
        }

        // GET: Media/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var media = await _context.Medias
                .Include(m => m.Movie)
                .Include(m => m.Product)
                .Include(m => m.Shops)
                .FirstOrDefaultAsync(m => m.MediaID == id);
            if (media == null)
            {
                return NotFound();
            }

            return View(media);
        }

        // POST: Media/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var media = await _context.Medias.FindAsync(id);
            _context.Medias.Remove(media);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MediaExists(int id)
        {
            return _context.Medias.Any(e => e.MediaID == id);
        }
    }
}
