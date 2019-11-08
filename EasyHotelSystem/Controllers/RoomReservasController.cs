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
    public class RoomReservasController : Controller
    {
        private readonly EasyHotelSystemContext _context;

        public RoomReservasController(EasyHotelSystemContext context)
        {
            _context = context;
        }

        // GET: RoomReservas
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoomReserva.ToListAsync());
        }

        // GET: RoomReservas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomReserva = await _context.RoomReserva
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomReserva == null)
            {
                return NotFound();
            }

            return View(roomReserva);
        }

        // GET: RoomReservas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomReservas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuarID,ResID,Id")] RoomReserva roomReserva)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomReserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomReserva);
        }

        // GET: RoomReservas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomReserva = await _context.RoomReserva.FindAsync(id);
            if (roomReserva == null)
            {
                return NotFound();
            }
            return View(roomReserva);
        }

        // POST: RoomReservas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuarID,ResID,Id")] RoomReserva roomReserva)
        {
            if (id != roomReserva.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomReserva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomReservaExists(roomReserva.Id))
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
            return View(roomReserva);
        }

        // GET: RoomReservas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomReserva = await _context.RoomReserva
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomReserva == null)
            {
                return NotFound();
            }

            return View(roomReserva);
        }

        // POST: RoomReservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomReserva = await _context.RoomReserva.FindAsync(id);
            _context.RoomReserva.Remove(roomReserva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomReservaExists(int id)
        {
            return _context.RoomReserva.Any(e => e.Id == id);
        }
    }
}
