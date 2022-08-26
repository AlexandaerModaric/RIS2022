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
    public class ProceduretypesController : Controller
    {
        private readonly RisDBContext _context;

        public ProceduretypesController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Proceduretypes
        public async Task<IActionResult> Index()
        {
              return _context.Proceduretypes != null ? 
                          View(await _context.Proceduretypes.ToListAsync()) :
                          Problem("Entity set 'RisDBContext.Proceduretypes'  is null.");
        }

        // GET: Proceduretypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Proceduretypes == null)
            {
                return NotFound();
            }

            var proceduretype = await _context.Proceduretypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proceduretype == null)
            {
                return NotFound();
            }

            return View(proceduretype);
        }

        // GET: Proceduretypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Proceduretypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Parentnum,Namear,Nameen")] Proceduretype proceduretype)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proceduretype);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proceduretype);
        }

        // GET: Proceduretypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Proceduretypes == null)
            {
                return NotFound();
            }

            var proceduretype = await _context.Proceduretypes.FindAsync(id);
            if (proceduretype == null)
            {
                return NotFound();
            }
            return View(proceduretype);
        }

        // POST: Proceduretypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Parentnum,Namear,Nameen")] Proceduretype proceduretype)
        {
            if (id != proceduretype.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proceduretype);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProceduretypeExists(proceduretype.Id))
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
            return View(proceduretype);
        }

        // GET: Proceduretypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Proceduretypes == null)
            {
                return NotFound();
            }

            var proceduretype = await _context.Proceduretypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proceduretype == null)
            {
                return NotFound();
            }

            return View(proceduretype);
        }

        // POST: Proceduretypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Proceduretypes == null)
            {
                return Problem("Entity set 'RisDBContext.Proceduretypes'  is null.");
            }
            var proceduretype = await _context.Proceduretypes.FindAsync(id);
            if (proceduretype != null)
            {
                _context.Proceduretypes.Remove(proceduretype);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProceduretypeExists(int id)
        {
          return (_context.Proceduretypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
