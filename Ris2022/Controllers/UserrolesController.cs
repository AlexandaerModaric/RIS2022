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
    public class UserrolesController : Controller
    {
        private readonly RisDBContext _context;

        public UserrolesController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Userroles
        public async Task<IActionResult> Index()
        {
              return _context.Userroles != null ? 
                          View(await _context.Userroles.ToListAsync()) :
                          Problem("Entity set 'RisDBContext.Userroles'  is null.");
        }

        // GET: Userroles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Userroles == null)
            {
                return NotFound();
            }

            var userrole = await _context.Userroles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userrole == null)
            {
                return NotFound();
            }

            return View(userrole);
        }

        // GET: Userroles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Userroles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Userrole userrole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userrole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userrole);
        }

        // GET: Userroles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Userroles == null)
            {
                return NotFound();
            }

            var userrole = await _context.Userroles.FindAsync(id);
            if (userrole == null)
            {
                return NotFound();
            }
            return View(userrole);
        }

        // POST: Userroles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Userrole userrole)
        {
            if (id != userrole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userrole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserroleExists(userrole.Id))
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
            return View(userrole);
        }

        // GET: Userroles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Userroles == null)
            {
                return NotFound();
            }

            var userrole = await _context.Userroles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userrole == null)
            {
                return NotFound();
            }

            return View(userrole);
        }

        // POST: Userroles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Userroles == null)
            {
                return Problem("Entity set 'RisDBContext.Userroles'  is null.");
            }
            var userrole = await _context.Userroles.FindAsync(id);
            if (userrole != null)
            {
                _context.Userroles.Remove(userrole);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserroleExists(int id)
        {
          return (_context.Userroles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
