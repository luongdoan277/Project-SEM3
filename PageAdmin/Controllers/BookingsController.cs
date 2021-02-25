using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PageAdmin.Data;
using PageAdmin.Models;
using PageAdmin.Models.ViewModels;

namespace PageAdmin.Controllers
{
    public class BookingsController : Controller
    {
        private readonly PageAdminContext _context;
        private readonly IStoreRepository repository;

        public BookingsController(PageAdminContext context, IStoreRepository _repository)
        {
            _context = context;
            repository = _repository;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var pageAdminContext = _context.Bookings.Include(b => b.Shows).Include(b => b.UserBooking).OrderByDescending(m => m.BookingID);
            return View(await pageAdminContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BookingListViewModel model = new BookingListViewModel
            {
                Bookings = repository.Bookings
                .Include(b => b.Shows.Movie)
                .Include(b => b.UserBooking)
                .Where(m => m.BookingID == id),
                ShowSeats = repository.ShowSeats.Where(m => m.BookingID == id).Include(m => m.CinemaSeat)
            };
            
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        //// GET: Bookings/Create
        //public IActionResult Create()
        //{
        //    ViewData["ShowID"] = new SelectList(_context.Shows, "ShowID", "ShowID");
        //    ViewData["UserBookingID"] = new SelectList(_context.UserBookings, "UserBookingID", "UserBookingID");
        //    return View();
        //}

        //// POST: Bookings/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("BookingID,NumberOfSeat,Timestamp,Status,UserBookingID,ShowID")] Booking booking)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(booking);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["ShowID"] = new SelectList(_context.Shows, "ShowID", "ShowID", booking.ShowID);
        //    ViewData["UserBookingID"] = new SelectList(_context.UserBookings, "UserBookingID", "UserBookingID", booking.UserBookingID);
        //    return View(booking);
        //}

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["ShowID"] = new SelectList(_context.Shows, "ShowID", "ShowID", booking.ShowID);
            ViewData["UserBookingID"] = new SelectList(_context.UserBookings, "UserBookingID", "UserBookingID", booking.UserBookingID);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingID,NumberOfSeat,Timestamp,Status,UserBookingID,ShowID")] Booking booking)
        {
            if (id != booking.BookingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingID))
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
            ViewData["ShowID"] = new SelectList(_context.Shows, "ShowID", "ShowID", booking.ShowID);
            ViewData["UserBookingID"] = new SelectList(_context.UserBookings, "UserBookingID", "UserBookingID", booking.UserBookingID);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Shows)
                .Include(b => b.UserBooking)
                .FirstOrDefaultAsync(m => m.BookingID == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingID == id);
        }
    }
}
