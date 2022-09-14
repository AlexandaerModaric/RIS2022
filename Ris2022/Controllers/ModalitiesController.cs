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
    public class ModalitiesController : Controller
    {
        private readonly RisDBContext _context;

        public ModalitiesController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Modalities
        public async Task<IActionResult> Index()
        {
            var risDBContext = _context.Modalities.Include(m => m.Department).Include(m => m.Modalitytype);
            return View(await risDBContext.ToListAsync());
        }

        // GET: Modalities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Modalities == null)
            {
                return NotFound();
            }
            var modalities = await _context.Modalities.Where(x => x.Id == id)
                .Include(m => m.Department)
                .Include(m => m.Modalitytype)
                .Take(1).ToListAsync();
            var modality = modalities.FirstOrDefault();
            if (modality == null)
            {
                return NotFound();
            }

            return View(modality);
        }

        // GET: Modalities/Create
        public IActionResult Create()
        {
            ViewData["Departmentid"] = new SelectList(_context.Departments, "Id", "Namear");
            ViewData["Modalitytypeid"] = new SelectList(_context.Modalitytypes, "Id", "Namear");
            return View();
        }

        // POST: Modalities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Aetitle,Ipaddress,Port,Modalitytypeid,Description,Departmentid")] Modality modality)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modality);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Departmentid"] = new SelectList(_context.Departments, "Id", "Namear", modality.Departmentid);
            ViewData["Modalitytypeid"] = new SelectList(_context.Modalitytypes, "Id", "Namear", modality.Modalitytypeid);
            return View(modality);
        }

        // GET: Modalities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Modalities == null)
            {
                return NotFound();
            }

            var modality = await _context.Modalities.FindAsync(id);
            if (modality == null)
            {
                return NotFound();
            }
            ViewData["Departmentid"] = new SelectList(_context.Departments, "Id", "Namear", modality.Departmentid);
            ViewData["Modalitytypeid"] = new SelectList(_context.Modalitytypes, "Id", "Namear", modality.Modalitytypeid);
            return View(modality);
        }

        // POST: Modalities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Aetitle,Ipaddress,Port,Modalitytypeid,Description,Departmentid")] Modality modality)
        {
            if (id != modality.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modality);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModalityExists(modality.Id))
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
            ViewData["Departmentid"] = new SelectList(_context.Departments, "Id", "Namear", modality.Departmentid);
            ViewData["Modalitytypeid"] = new SelectList(_context.Modalitytypes, "Id", "Namear", modality.Modalitytypeid);
            return View(modality);
        }

        // GET: Modalities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Modalities == null)
            {
                return NotFound();
            }

            var modalities = await _context.Modalities.Where(x => x.Id == id)
                .Include(m => m.Department)
                .Include(m => m.Modalitytype)
                .Take(1).ToListAsync();
            var modality = modalities.FirstOrDefault();
            if (modality == null)
            {
                return NotFound();
            }

            return View(modality);
        }

        // POST: Modalities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Modalities == null)
            {
                return Problem("Entity set 'RisDBContext.Modalities'  is null.");
            }
            var modality = await _context.Modalities.FindAsync(id);
            if (modality != null)
            {
                _context.Modalities.Remove(modality);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModalityExists(int id)
        {
          return (_context.Modalities?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
