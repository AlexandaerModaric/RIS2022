using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ris2022.Data;
using Ris2022.Data.Models;
using Ris2022.MllpHl7Client;
using System.Text;
using Microsoft.AspNetCore.Components.Web;

namespace Ris2022.Controllers
{
    public class OrdersController : Controller
    {
        private readonly RisDBContext _context;

        public OrdersController(RisDBContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {

            return _context.orders != null ? 
                          View(await _context.orders.ToListAsync()) :
                          Problem("Entity set 'RisDBContext.orders'  is null.");
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.orders == null)
            {
                return NotFound();
            }

            var order = await _context.orders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create(int patientId)
        {
            Order order = new();
            order.Patientid = patientId;
            order.Studyid = "1.2.4.0.13.1.4.2252867." + patientId;
            ViewData["Modalityid"] = new SelectList(_context.Modalities.ToList(),"Id","Name");
            ViewData["Proceduretypeid"] = new SelectList(_context.Proceduretypes.ToList(),"Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            //ViewData["Doctorid"] = new SelectList(_context.Risusers.ToList().DistinctBy(c=>c.Isdoctor==true),"Id","Name");
            ViewData["Departmentid"] = new SelectList(_context.Departments.ToList(),"Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["ordertypeid"] = new SelectList(_context.Modalitytypes.ToList(),"Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["Reasonid"] = new SelectList(_context.Reasons.ToList(),"Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["Paytypeid"] = new SelectList(_context.Paytypes.ToList(),"Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["Payreasonid"] = new SelectList(_context.Reasons.ToList(),"Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["Clinicid"] = new SelectList(_context.Clinics.ToList(),"Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["Modalitytypeid"] = new SelectList(_context.Modalitytypes.ToList(),"Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            return View(order);
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Order order)
        {
            Patient patient = _context.Patients.SingleOrDefault(p => p.Id == order.Patientid);
            Modality modality = _context.Modalities.SingleOrDefault(m => m.Id == order.Modalityid);
            ViewData["Modalityid"] = new SelectList(_context.Modalities.ToList(), "Id", "Name");
            ViewData["Proceduretypeid"] = new SelectList(_context.Proceduretypes.ToList(), "Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            //ViewData["Doctorid"] = new SelectList(_context.Risusers.ToList().DistinctBy(c => c.Isdoctor == true), "Id", "Name");
            ViewData["Departmentid"] = new SelectList(_context.Departments.ToList(), "Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["ordertypeid"] = new SelectList(_context.Modalitytypes.ToList(), "Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["Reasonid"] = new SelectList(_context.Reasons.ToList(), "Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["Paytypeid"] = new SelectList(_context.Paytypes.ToList(), "Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["Payreasonid"] = new SelectList(_context.Reasons.ToList(), "Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["Clinicid"] = new SelectList(_context.Clinics.ToList(), "Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            ViewData["Modalitytypeid"] = new SelectList(_context.Modalitytypes.ToList(), "Id", Thread.CurrentThread.CurrentCulture.ToString().Contains("ar") ? "Namear" : "Nameen");
            HL7message hL7Message = new HL7message();
            order.Accessionnumber = int.Parse(patient.Id+ DateTime.Now.ToString("ssmm"));
            order.Insertuserid = 1;
            order.Startdate = DateTime.UtcNow;
            hL7Message.studyId = order.Studyid;
            hL7Message.accessionNumber = order.Accessionnumber.ToString();
            hL7Message.patientGivenId = patient.Givenid;
            hL7Message.aeTitle = modality.Aetitle;
            hL7Message.sStationName = modality.Name;
            hL7Message.obsOrderPFNum = patient.Id;
            hL7Message.patientFirstName = patient.Firstname;
            hL7Message.patientLastName = patient.Lastname;
            hL7Message.modalityName = modality.Name;
            hL7Message.startDateTime = "20220419183649";
            hL7Message.procedureId = order.Proceduretypeid.Value;
            hL7Message.procedureName = _context.Proceduretypes.SingleOrDefault(proc=>proc.Id==order.Proceduretypeid).Nameen;
            if (ModelState.IsValid && Hl7Client.SendHl7Msg(hL7Message))
            {
                
                _context.Add(order);
                await _context.SaveChangesAsync();
                //var testHl7MessageToTransmit = new StringBuilder();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.orders == null)
            {
                return NotFound();
            }

            var order = await _context.orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Patientid,Modalityid,Proceduretypeid,Studyid,Startdate,Enddate,Statusid,Doctorid,Autoexpiredate,Accessionnumber,Departmentid,Documentid,Typeid,Insertdate,Insertuserid,Reasonid,Updateuserid,Updatedate,Paytypeid,Payreasonid,Clinicid,Modalitytypeid")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
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
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.orders == null)
            {
                return NotFound();
            }

            var order = await _context.orders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.orders == null)
            {
                return Problem("Entity set 'RisDBContext.orders'  is null.");
            }
            var order = await _context.orders.FindAsync(id);
            if (order != null)
            {
                _context.orders.Remove(order);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
          return (_context.orders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
