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
    public class EmployeeReservasController : Controller
    {
        private readonly EasyHotelSystemContext _context;

        public EmployeeReservasController(EasyHotelSystemContext context)
        {
            _context = context;
        }

        // GET: EmployeeReservas
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeReserva.ToListAsync());
        }

        // GET: EmployeeReservas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeReserva = await _context.EmployeeReserva
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeReserva == null)
            {
                return NotFound();
            }

            return View(employeeReserva);
        }

        // GET: EmployeeReservas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeReservas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuncID,ResID,Id")] EmployeeReserva employeeReserva)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeReserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeReserva);
        }

        // GET: EmployeeReservas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeReserva = await _context.EmployeeReserva.FindAsync(id);
            if (employeeReserva == null)
            {
                return NotFound();
            }
            return View(employeeReserva);
        }

        // POST: EmployeeReservas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuncID,ResID,Id")] EmployeeReserva employeeReserva)
        {
            if (id != employeeReserva.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeReserva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeReservaExists(employeeReserva.Id))
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
            return View(employeeReserva);
        }

        // GET: EmployeeReservas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeReserva = await _context.EmployeeReserva
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeReserva == null)
            {
                return NotFound();
            }

            return View(employeeReserva);
        }

        // POST: EmployeeReservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeReserva = await _context.EmployeeReserva.FindAsync(id);
            _context.EmployeeReserva.Remove(employeeReserva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeReservaExists(int id)
        {
            return _context.EmployeeReserva.Any(e => e.Id == id);
        }
    }
}
