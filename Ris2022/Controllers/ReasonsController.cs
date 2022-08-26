using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ris2022.Data;
using Ris2022.Data.Models;

namespace Ris2022.Controllers
{
    public class ReasonsController : Controller
    {
        private readonly RisDBContext _context;

        public ReasonsController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Reasons
        public async Task<IActionResult> Index()
        {
              return _context.Reasons != null ? 
                          View(await _context.Reasons.ToListAsync()) :
                          Problem("Entity set 'RisDBContext.Reasons'  is null.");
        }

        // GET: Reasons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reasons == null)
            {
                return NotFound();
            }

            var reason = await _context.Reasons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reason == null)
            {
                return NotFound();
            }

            return View(reason);
        }

        // GET: Reasons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reasons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Namear,Nameen")] Reason reason)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reason);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reason);
        }

        // GET: Reasons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Reasons == null)
            {
                return NotFound();
            }

            var reason = await _context.Reasons.FindAsync(id);
            if (reason == null)
            {
                return NotFound();
            }
            return View(reason);
        }

        // POST: Reasons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Namear,Nameen")] Reason reason)
        {
            if (id != reason.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reason);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReasonExists(reason.Id))
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
            return View(reason);
        }

        // GET: Reasons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Reasons == null)
            {
                return NotFound();
            }

            var reason = await _context.Reasons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reason == null)
            {
                return NotFound();
            }

            return View(reason);
        }

        // POST: Reasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Reasons == null)
            {
                return Problem("Entity set 'RisDBContext.Reasons'  is null.");
            }
            var reason = await _context.Reasons.FindAsync(id);
            if (reason != null)
            {
                _context.Reasons.Remove(reason);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReasonExists(int id)
        {
          return (_context.Reasons?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
