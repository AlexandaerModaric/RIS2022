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
    public class PaytypesController : Controller
    {
        private readonly RisDBContext _context;

        public PaytypesController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Paytypes
        public async Task<IActionResult> Index()
        {
              return _context.Paytypes != null ? 
                          View(await _context.Paytypes.ToListAsync()) :
                          Problem("Entity set 'RisDBContext.Paytypes'  is null.");
        }

        // GET: Paytypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Paytypes == null)
            {
                return NotFound();
            }

            var paytype = await _context.Paytypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paytype == null)
            {
                return NotFound();
            }

            return View(paytype);
        }

        // GET: Paytypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Paytypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Namear,Nameen")] Paytype paytype)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paytype);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paytype);
        }

        // GET: Paytypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Paytypes == null)
            {
                return NotFound();
            }

            var paytype = await _context.Paytypes.FindAsync(id);
            if (paytype == null)
            {
                return NotFound();
            }
            return View(paytype);
        }

        // POST: Paytypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Namear,Nameen")] Paytype paytype)
        {
            if (id != paytype.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paytype);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaytypeExists(paytype.Id))
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
            return View(paytype);
        }

        // GET: Paytypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Paytypes == null)
            {
                return NotFound();
            }

            var paytype = await _context.Paytypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paytype == null)
            {
                return NotFound();
            }

            return View(paytype);
        }

        // POST: Paytypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Paytypes == null)
            {
                return Problem("Entity set 'RisDBContext.Paytypes'  is null.");
            }
            var paytype = await _context.Paytypes.FindAsync(id);
            if (paytype != null)
            {
                _context.Paytypes.Remove(paytype);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaytypeExists(int id)
        {
          return (_context.Paytypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
