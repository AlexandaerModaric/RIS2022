using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ris2022.Data;
using Ris2022.Data.Models;
using Ris2022.Interfaces;
using Ris2022.Resources;

namespace Ris2022.Controllers
{
    public class PatientsController : Controller
    {
        private readonly RisDBContext _context;

        //public PatientsController(RisDBContext context)
        //{
        //    _context = context;

        //}
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<RisAppUser> _userManager;

        public PatientsController(IUnitOfWork unitOfWork, RisDBContext context, UserManager<RisAppUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _userManager = userManager;

        }

        // GET: Patients
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index()
        {
              return _unitOfWork.Patients != null ? 
                          View( _unitOfWork.Patients.GetAll()) :
                          Problem("Entity set 'RisDBContext.Patients'  is null.");
        }

        // GET: Patients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Patients == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        // GET: Patients/Create
        public IActionResult Create()
        {
            ViewData["Nationalityid"] = new SelectList(_context.Nationalities.ToList(), "Id", Resource.ENARName);
            ViewData["Worktypeid"] = new SelectList(_context.Worktypes.ToList(), "Id", Resource.ENARName);
            ViewData["Martialstatusid"] = new SelectList(_context.Martialstatuses.ToList(), "Id", Resource.ENARName);
            ViewData["Acceptancetypeid"] = new SelectList(_context.Acceptancetypes.ToList(), "Id", Resource.ENARName);
            Patient patient = new Patient();
            patient.InsertUserName = User.FindFirstValue(ClaimTypes.Name);

            patient.patientOrders = new Order[] { };
            return View(patient);
        }

        // POST: Patients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(Patient patient)
        {
            ViewData["Nationalityid"] = new SelectList(_context.Nationalities.ToList(), "Id", Resource.ENARName,patient.Nationalityid);
            ViewData["Worktypeid"] = new SelectList(_context.Worktypes.ToList(), "Id", Resource.ENARName,patient.Worktypeid);
            ViewData["Martialstatusid"] = new SelectList(_context.Martialstatuses.ToList(), "Id", Resource.ENARName, patient.Martialstatusid);
            ViewData["Acceptancetypeid"] = new SelectList(_context.Acceptancetypes.ToList(), "Id", Resource.ENARName, patient.Acceptancetypeid);
            patient.InsertUserName = User.FindFirstValue(ClaimTypes.Name);
            patient.patientOrders = new Order[] {};
            if (ModelState.IsValid)
            {
                _context.Add(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            foreach (var error in ModelState.Values.SelectMany(modelState => modelState.Errors))
                ModelState.AddModelError(string.Empty, error.ToString());
            return View(patient);
        }

        // GET: Patients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Patients == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Givenid,Firstname,Middlename,Lastname,Gendre")] Patient patient)
        {
            if (id != patient.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientExists(patient.Id))
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
            return View(patient);
        }

        // GET: Patients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Patients == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Patients == null)
            {
                return Problem("Entity set 'RisDBContext.Patients'  is null.");
            }
            var patient = await _context.Patients.FindAsync(id);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientExists(int id)
        {
          return (_context.Patients?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
