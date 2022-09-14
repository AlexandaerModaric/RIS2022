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
    public class WorktypesController : Controller
    {
        private readonly RisDBContext _context;

        public WorktypesController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Worktypes
        public async Task<IActionResult> Index()
        {
              return _context.Worktypes != null ? 
                          View(await _context.Worktypes.ToListAsync()) :
                          Problem("Entity set 'RisDBContext.Worktypes'  is null.");
        }

        // GET: Worktypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Worktypes == null)
            {
                return NotFound();
            }

            var worktype = await _context.Worktypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (worktype == null)
            {
                return NotFound();
            }

            return View(worktype);
        }

        // GET: Worktypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Worktypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Namear,Nameen")] Worktype worktype)
        {
            if (ModelState.IsValid)
            {
                _context.Add(worktype);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(worktype);
        }

        // GET: Worktypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Worktypes == null)
            {
                return NotFound();
            }

            var worktype = await _context.Worktypes.FindAsync(id);
            if (worktype == null)
            {
                return NotFound();
            }
            return View(worktype);
        }

        // POST: Worktypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Namear,Nameen")] Worktype worktype)
        {
            if (id != worktype.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(worktype);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorktypeExists(worktype.Id))
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
            return View(worktype);
        }

        // GET: Worktypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Worktypes == null)
            {
                return NotFound();
            }

            var worktype = await _context.Worktypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (worktype == null)
            {
                return NotFound();
            }

            return View(worktype);
        }

        // POST: Worktypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Worktypes == null)
            {
                return Problem("Entity set 'RisDBContext.Worktypes'  is null.");
            }
            var worktype = await _context.Worktypes.FindAsync(id);
            if (worktype != null)
            {
                _context.Worktypes.Remove(worktype);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorktypeExists(int id)
        {
          return (_context.Worktypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
