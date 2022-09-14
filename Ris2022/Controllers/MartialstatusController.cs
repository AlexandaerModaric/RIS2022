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
    public class MartialstatusController : Controller
    {
        private readonly RisDBContext _context;

        public MartialstatusController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Martialstatus
        public async Task<IActionResult> Index()
        {
              return _context.Martialstatuses != null ? 
                          View(await _context.Martialstatuses.ToListAsync()) :
                          Problem("Entity set 'RisDBContext.Martialstatuses'  is null.");
        }

        // GET: Martialstatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Martialstatuses == null)
            {
                return NotFound();
            }

            var martialstatus = await _context.Martialstatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (martialstatus == null)
            {
                return NotFound();
            }

            return View(martialstatus);
        }

        // GET: Martialstatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Martialstatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Namear,Nameen")] Martialstatus martialstatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(martialstatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(martialstatus);
        }

        // GET: Martialstatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Martialstatuses == null)
            {
                return NotFound();
            }

            var martialstatus = await _context.Martialstatuses.FindAsync(id);
            if (martialstatus == null)
            {
                return NotFound();
            }
            return View(martialstatus);
        }

        // POST: Martialstatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Namear,Nameen")] Martialstatus martialstatus)
        {
            if (id != martialstatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(martialstatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MartialstatusExists(martialstatus.Id))
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
            return View(martialstatus);
        }

        // GET: Martialstatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Martialstatuses == null)
            {
                return NotFound();
            }

            var martialstatus = await _context.Martialstatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (martialstatus == null)
            {
                return NotFound();
            }

            return View(martialstatus);
        }

        // POST: Martialstatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Martialstatuses == null)
            {
                return Problem("Entity set 'RisDBContext.Martialstatuses'  is null.");
            }
            var martialstatus = await _context.Martialstatuses.FindAsync(id);
            if (martialstatus != null)
            {
                _context.Martialstatuses.Remove(martialstatus);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MartialstatusExists(int id)
        {
          return (_context.Martialstatuses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
