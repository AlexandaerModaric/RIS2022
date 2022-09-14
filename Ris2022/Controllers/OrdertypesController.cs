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
    public class OrdertypesController : Controller
    {
        private readonly RisDBContext _context;

        public OrdertypesController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Ordertypes
        public async Task<IActionResult> Index()
        {
              return _context.Ordetypes != null ? 
                          View(await _context.Ordetypes.ToListAsync()) :
                          Problem("Entity set 'RisDBContext.Ordetypes'  is null.");
        }

        // GET: Ordertypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ordetypes == null)
            {
                return NotFound();
            }

            var ordertype = await _context.Ordetypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordertype == null)
            {
                return NotFound();
            }

            return View(ordertype);
        }

        // GET: Ordertypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ordertypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Namear,Nameen")] Ordertype ordertype)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordertype);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordertype);
        }

        // GET: Ordertypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ordetypes == null)
            {
                return NotFound();
            }

            var ordertype = await _context.Ordetypes.FindAsync(id);
            if (ordertype == null)
            {
                return NotFound();
            }
            return View(ordertype);
        }

        // POST: Ordertypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Namear,Nameen")] Ordertype ordertype)
        {
            if (id != ordertype.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordertype);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdertypeExists(ordertype.Id))
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
            return View(ordertype);
        }

        // GET: Ordertypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ordetypes == null)
            {
                return NotFound();
            }

            var ordertype = await _context.Ordetypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordertype == null)
            {
                return NotFound();
            }

            return View(ordertype);
        }

        // POST: Ordertypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ordetypes == null)
            {
                return Problem("Entity set 'RisDBContext.Ordetypes'  is null.");
            }
            var ordertype = await _context.Ordetypes.FindAsync(id);
            if (ordertype != null)
            {
                _context.Ordetypes.Remove(ordertype);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdertypeExists(int id)
        {
          return (_context.Ordetypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
