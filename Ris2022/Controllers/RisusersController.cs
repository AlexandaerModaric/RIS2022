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
    public class RisusersController : Controller
    {
        private readonly RisDBContext _context;

        public RisusersController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Risusers
        public async Task<IActionResult> Index()
        {
              return _context.Risusers != null ? 
                          View(await _context.Risusers.ToListAsync()) :
                          Problem("Entity set 'RisDBContext.Risusers'  is null.");
        }

        // GET: Risusers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Risusers == null)
            {
                return NotFound();
            }

            var risuser = await _context.Risusers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (risuser == null)
            {
                return NotFound();
            }

            return View(risuser);
        }

        // GET: Risusers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Risusers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Pass,Languageid,Userroleid,Firstname,Lastname,Departmentid,Isdoctor")] Risuser risuser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(risuser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(risuser);
        }

        // GET: Risusers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Risusers == null)
            {
                return NotFound();
            }

            var risuser = await _context.Risusers.FindAsync(id);
            if (risuser == null)
            {
                return NotFound();
            }
            return View(risuser);
        }

        // POST: Risusers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Pass,Languageid,Userroleid,Firstname,Lastname,Departmentid,Isdoctor")] Risuser risuser)
        {
            if (id != risuser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(risuser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RisuserExists(risuser.Id))
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
            return View(risuser);
        }

        // GET: Risusers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Risusers == null)
            {
                return NotFound();
            }

            var risuser = await _context.Risusers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (risuser == null)
            {
                return NotFound();
            }

            return View(risuser);
        }

        // POST: Risusers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Risusers == null)
            {
                return Problem("Entity set 'RisDBContext.Risusers'  is null.");
            }
            var risuser = await _context.Risusers.FindAsync(id);
            if (risuser != null)
            {
                _context.Risusers.Remove(risuser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RisuserExists(int id)
        {
          return (_context.Risusers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
