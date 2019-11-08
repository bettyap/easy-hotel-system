using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EasyHotelSystem.Models;

namespace EasyHotelSystem.Controllers
{
    public class EmployeePaymentsController : Controller
    {
        private readonly EasyHotelSystemContext _context;

        public EmployeePaymentsController(EasyHotelSystemContext context)
        {
            _context = context;
        }

        // GET: EmployeePayments
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeePayment.ToListAsync());
        }

        // GET: EmployeePayments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeePayment = await _context.EmployeePayment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeePayment == null)
            {
                return NotFound();
            }

            return View(employeePayment);
        }

        // GET: EmployeePayments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeePayments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuncID,PagID,Id")] EmployeePayment employeePayment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeePayment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeePayment);
        }

        // GET: EmployeePayments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeePayment = await _context.EmployeePayment.FindAsync(id);
            if (employeePayment == null)
            {
                return NotFound();
            }
            return View(employeePayment);
        }

        // POST: EmployeePayments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuncID,PagID,Id")] EmployeePayment employeePayment)
        {
            if (id != employeePayment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeePayment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeePaymentExists(employeePayment.Id))
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
            return View(employeePayment);
        }

        // GET: EmployeePayments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeePayment = await _context.EmployeePayment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeePayment == null)
            {
                return NotFound();
            }

            return View(employeePayment);
        }

        // POST: EmployeePayments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeePayment = await _context.EmployeePayment.FindAsync(id);
            _context.EmployeePayment.Remove(employeePayment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeePaymentExists(int id)
        {
            return _context.EmployeePayment.Any(e => e.Id == id);
        }
    }
}
