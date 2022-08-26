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
    public class ModalitytypesController : Controller
    {
        private readonly RisDBContext _context;

        public ModalitytypesController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Modalitytypes
        public async Task<IActionResult> Index()
        {
              return _context.Modalitytypes != null ? 
                          View(await _context.Modalitytypes.ToListAsync()) :
                          Problem("Entity set 'RisDBContext.Modalitytypes'  is null.");
        }

        // GET: Modalitytypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Modalitytypes == null)
            {
                return NotFound();
            }

            var modalitytype = await _context.Modalitytypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modalitytype == null)
            {
                return NotFound();
            }

            return View(modalitytype);
        }

        // GET: Modalitytypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Modalitytypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Namear,Nameen")] Modalitytype modalitytype)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modalitytype);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modalitytype);
        }

        // GET: Modalitytypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Modalitytypes == null)
            {
                return NotFound();
            }

            var modalitytype = await _context.Modalitytypes.FindAsync(id);
            if (modalitytype == null)
            {
                return NotFound();
            }
            return View(modalitytype);
        }

        // POST: Modalitytypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Namear,Nameen")] Modalitytype modalitytype)
        {
            if (id != modalitytype.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modalitytype);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModalitytypeExists(modalitytype.Id))
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
            return View(modalitytype);
        }

        // GET: Modalitytypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Modalitytypes == null)
            {
                return NotFound();
            }

            var modalitytype = await _context.Modalitytypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modalitytype == null)
            {
                return NotFound();
            }

            return View(modalitytype);
        }

        // POST: Modalitytypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Modalitytypes == null)
            {
                return Problem("Entity set 'RisDBContext.Modalitytypes'  is null.");
            }
            var modalitytype = await _context.Modalitytypes.FindAsync(id);
            if (modalitytype != null)
            {
                _context.Modalitytypes.Remove(modalitytype);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModalitytypeExists(int id)
        {
          return (_context.Modalitytypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
