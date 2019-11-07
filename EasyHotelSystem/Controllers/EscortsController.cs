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
    public class EscortsController : Controller
    {
        private readonly EasyHotelSystemContext _context;

        public EscortsController(EasyHotelSystemContext context)
        {
            _context = context;
        }

        // GET: Escorts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Escorts.ToListAsync());
        }

        // GET: Escorts/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var escorts = await _context.Escorts
                .FirstOrDefaultAsync(m => m.CpfAcom == id);
            if (escorts == null)
            {
                return NotFound();
            }

            return View(escorts);
        }

        // GET: Escorts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Escorts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CpfAcom,Nome,Rg,Nascim,Genero,Logradouro,Bairro,Complemento,Cidade,Cep,Telefone,Email,Celular,Responsavel,CpfHos")] Escorts escorts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(escorts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(escorts);
        }

        // GET: Escorts/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var escorts = await _context.Escorts.FindAsync(id);
            if (escorts == null)
            {
                return NotFound();
            }
            return View(escorts);
        }

        // POST: Escorts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("CpfAcom,Nome,Rg,Nascim,Genero,Logradouro,Bairro,Complemento,Cidade,Cep,Telefone,Email,Celular,Responsavel,CpfHos")] Escorts escorts)
        {
            if (id != escorts.CpfAcom)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(escorts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EscortsExists(escorts.CpfAcom))
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
            return View(escorts);
        }

        // GET: Escorts/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var escorts = await _context.Escorts
                .FirstOrDefaultAsync(m => m.CpfAcom == id);
            if (escorts == null)
            {
                return NotFound();
            }

            return View(escorts);
        }

        // POST: Escorts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var escorts = await _context.Escorts.FindAsync(id);
            _context.Escorts.Remove(escorts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EscortsExists(long id)
        {
            return _context.Escorts.Any(e => e.CpfAcom == id);
        }
    }
}
