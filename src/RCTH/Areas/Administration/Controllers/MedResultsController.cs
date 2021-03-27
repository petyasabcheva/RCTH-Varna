using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RCTH.Areas.Identity.Data;
using RCTH.Data;

namespace RCTH.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class MedResultsController : Controller
    {
        private readonly RCTHContext _context;

        public MedResultsController(RCTHContext context)
        {
            _context = context;
        }

        // GET: Administration/MedResults
        public async Task<IActionResult> Index()
        {
            var rCTHContext = _context.MedResults.Include(m => m.Donation);
            return View(await rCTHContext.ToListAsync());
        }

        // GET: Administration/MedResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medResult = await _context.MedResults
                .Include(m => m.Donation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medResult == null)
            {
                return NotFound();
            }

            return View(medResult);
        }

        // GET: Administration/MedResults/Create
        public IActionResult Create()
        {
            ViewData["DonationId"] = new SelectList(_context.Donations, "Id", "EGN");
            return View();
        }

        // POST: Administration/MedResults/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DonationId,dateReleased")] MedResult medResult)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medResult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DonationId"] = new SelectList(_context.Donations, "Id", "EGN", medResult.DonationId);
            return View(medResult);
        }

        // GET: Administration/MedResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medResult = await _context.MedResults.FindAsync(id);
            if (medResult == null)
            {
                return NotFound();
            }
            ViewData["DonationId"] = new SelectList(_context.Donations, "Id", "EGN", medResult.DonationId);
            return View(medResult);
        }

        // POST: Administration/MedResults/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DonationId,dateReleased")] MedResult medResult)
        {
            if (id != medResult.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medResult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedResultExists(medResult.Id))
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
            ViewData["DonationId"] = new SelectList(_context.Donations, "Id", "EGN", medResult.DonationId);
            return View(medResult);
        }

        // GET: Administration/MedResults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medResult = await _context.MedResults
                .Include(m => m.Donation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medResult == null)
            {
                return NotFound();
            }

            return View(medResult);
        }

        // POST: Administration/MedResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medResult = await _context.MedResults.FindAsync(id);
            _context.MedResults.Remove(medResult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedResultExists(int id)
        {
            return _context.MedResults.Any(e => e.Id == id);
        }
    }
}
