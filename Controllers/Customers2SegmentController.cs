using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AktiaHaastattelu.Data;
using AktiaHaastattelu.Models;

namespace AktiaHaastattelu.Controllers
{
    public class Customers2SegmentController : Controller
    {
        private readonly AktiaHaastatteluContext _context;

        public Customers2SegmentController(AktiaHaastatteluContext context)
        {
            _context = context;
        }

        // GET: Customers2Segment
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers2Segment.ToListAsync());
        }

        // GET: Customers2Segment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers2Segment = await _context.Customers2Segment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customers2Segment == null)
            {
                return NotFound();
            }

            return View(customers2Segment);
        }

        // GET: Customers2Segment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers2Segment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerId,SegmentId")] Customers2Segment customers2Segment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customers2Segment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customers2Segment);
        }

        // GET: Customers2Segment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers2Segment = await _context.Customers2Segment.FindAsync(id);
            if (customers2Segment == null)
            {
                return NotFound();
            }
            return View(customers2Segment);
        }

        // POST: Customers2Segment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerId,SegmentId")] Customers2Segment customers2Segment)
        {
            if (id != customers2Segment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customers2Segment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Customers2SegmentExists(customers2Segment.Id))
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
            return View(customers2Segment);
        }

        // GET: Customers2Segment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers2Segment = await _context.Customers2Segment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customers2Segment == null)
            {
                return NotFound();
            }

            return View(customers2Segment);
        }

        // POST: Customers2Segment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customers2Segment = await _context.Customers2Segment.FindAsync(id);
            _context.Customers2Segment.Remove(customers2Segment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Customers2SegmentExists(int id)
        {
            return _context.Customers2Segment.Any(e => e.Id == id);
        }
    }
}
