using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        private readonly IWebHostEnvironment webHostEnvironment;
        public MediaController(PageAdminContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
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
            ViewData["MovieID"] = _context.Movies.OrderBy(p => p.MovieID);
            ViewData["ProductID"] = _context.Products.OrderBy(p => p.ProductID);
            ViewData["ShopID"] = _context.Shops.OrderBy(p => p.ShopID);
            //ViewData["ShopID"] = new SelectList(_context.Shops, "ShopID", "ShopName");
            return View();
        }

        // POST: Media/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MediaID,ShopID,MovieID,ProductID")] Media media, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(file);
                _context.Add(new Media { Url = uniqueFileName, MovieID = media.MovieID, ProductID = media.ProductID, ShopID = media.ShopID });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieID"] = _context.Movies.OrderBy(p => p.MovieID);
            ViewData["ProductID"] = _context.Products.OrderBy(p => p.ProductID);
            ViewData["ShopID"] = _context.Shops.OrderBy(p => p.ShopID);
            //ViewData["ShopID"] = new SelectList(_context.Shops, "ShopID", "ShopName", media.ShopID);
            return View(media);
        }
        public string UploadedFile(IFormFile file)
        {
            string uniqueFileName = null;

            if (file != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using FileStream fileStream = new FileStream(filePath, FileMode.Create);
                file.CopyTo(fileStream);
            }
            return uniqueFileName;
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
            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "Title", media.MovieID);
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductName", media.ProductID);
            ViewData["ShopID"] = new SelectList(_context.Shops, "ShopID", "ShopName", media.ShopID);
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
            ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "Title", media.MovieID);
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductName", media.ProductID);
            ViewData["ShopID"] = new SelectList(_context.Shops, "ShopID", "ShopName", media.ShopID);
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
