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
    public class DonationsController : Controller
    {
        private readonly RCTHContext _context;

        public DonationsController(RCTHContext context)
        {
            _context = context;
        }

        // GET: Administration/Donations
        public async Task<IActionResult> Index()
        {
            var rCTHContext = _context.Donations.Include(d => d.BloodGroup).Include(d => d.User);
            return View(await rCTHContext.ToListAsync());
        }

        // GET: Administration/Donations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donation = await _context.Donations
                .Include(d => d.BloodGroup)
                .Include(d => d.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donation == null)
            {
                return NotFound();
            }

            return View(donation);
        }

        // GET: Administration/Donations/Create
        public IActionResult Create()
        {
            ViewData["BloodGroupId"] = new SelectList(_context.BloodGroups, "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.RCTHUsers, "Id", "Id");
            return View();
        }

        // POST: Administration/Donations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,EGN,dateDonated,Quantity,BloodGroupId,Receiver")] Donation donation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BloodGroupId"] = new SelectList(_context.BloodGroups, "Id", "Name", donation.BloodGroupId);
            ViewData["UserId"] = new SelectList(_context.RCTHUsers, "Id", "Id", donation.UserId);
            return View(donation);
        }

        // GET: Administration/Donations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donation = await _context.Donations.FindAsync(id);
            if (donation == null)
            {
                return NotFound();
            }
            ViewData["BloodGroupId"] = new SelectList(_context.BloodGroups, "Id", "Name", donation.BloodGroupId);
            ViewData["UserId"] = new SelectList(_context.RCTHUsers, "Id", "Id", donation.UserId);
            return View(donation);
        }

        // POST: Administration/Donations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,EGN,dateDonated,Quantity,BloodGroupId,Receiver")] Donation donation)
        {
            if (id != donation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonationExists(donation.Id))
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
            ViewData["BloodGroupId"] = new SelectList(_context.BloodGroups, "Id", "Name", donation.BloodGroupId);
            ViewData["UserId"] = new SelectList(_context.RCTHUsers, "Id", "Id", donation.UserId);
            return View(donation);
        }

        // GET: Administration/Donations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donation = await _context.Donations
                .Include(d => d.BloodGroup)
                .Include(d => d.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donation == null)
            {
                return NotFound();
            }

            return View(donation);
        }

        // POST: Administration/Donations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donation = await _context.Donations.FindAsync(id);
            _context.Donations.Remove(donation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonationExists(int id)
        {
            return _context.Donations.Any(e => e.Id == id);
        }
    }
}
