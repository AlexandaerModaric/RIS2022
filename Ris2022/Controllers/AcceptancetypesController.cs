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
    public class AcceptancetypesController : Controller
    {
        private readonly RisDBContext _context;

        public AcceptancetypesController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Acceptancetypes
        public async Task<IActionResult> Index()
        {
              return _context.Acceptancetypes != null ? 
                          View(await _context.Acceptancetypes.ToListAsync()) :
                          Problem("Entity set 'RisDBContext.Acceptancetypes'  is null.");
        }

        // GET: Acceptancetypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Acceptancetypes == null)
            {
                return NotFound();
            }

            var acceptancetype = await _context.Acceptancetypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acceptancetype == null)
            {
                return NotFound();
            }

            return View(acceptancetype);
        }

        // GET: Acceptancetypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Acceptancetypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Namear,Nameen")] Acceptancetype acceptancetype)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acceptancetype);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(acceptancetype);
        }

        // GET: Acceptancetypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Acceptancetypes == null)
            {
                return NotFound();
            }

            var acceptancetype = await _context.Acceptancetypes.FindAsync(id);
            if (acceptancetype == null)
            {
                return NotFound();
            }
            return View(acceptancetype);
        }

        // POST: Acceptancetypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Namear,Nameen")] Acceptancetype acceptancetype)
        {
            if (id != acceptancetype.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acceptancetype);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcceptancetypeExists(acceptancetype.Id))
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
            return View(acceptancetype);
        }

        // GET: Acceptancetypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Acceptancetypes == null)
            {
                return NotFound();
            }

            var acceptancetype = await _context.Acceptancetypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acceptancetype == null)
            {
                return NotFound();
            }

            return View(acceptancetype);
        }

        // POST: Acceptancetypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Acceptancetypes == null)
            {
                return Problem("Entity set 'RisDBContext.Acceptancetypes'  is null.");
            }
            var acceptancetype = await _context.Acceptancetypes.FindAsync(id);
            if (acceptancetype != null)
            {
                _context.Acceptancetypes.Remove(acceptancetype);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcceptancetypeExists(int id)
        {
          return (_context.Acceptancetypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
