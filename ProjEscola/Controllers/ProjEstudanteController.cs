using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjEscola.Data;
using ProjEscola.Models;

namespace ProjEscola.Controllers
{
    public class ProjEstudanteController : Controller
    {
        private readonly ProjEscolaContext _context;

        public ProjEstudanteController(ProjEscolaContext context)
        {
            _context = context;
        }

        // GET: ProjEstudante
        public async Task<IActionResult> Index()
        {
              return View(await _context.ProjEstudante.ToListAsync());
        }

        // GET: ProjEstudante/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProjEstudante == null)
            {
                return NotFound();
            }

            var projEstudante = await _context.ProjEstudante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projEstudante == null)
            {
                return NotFound();
            }

            return View(projEstudante);
        }

        // GET: ProjEstudante/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjEstudante/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeEstudante")] ProjEstudante projEstudante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projEstudante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projEstudante);
        }

        // GET: ProjEstudante/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProjEstudante == null)
            {
                return NotFound();
            }

            var projEstudante = await _context.ProjEstudante.FindAsync(id);
            if (projEstudante == null)
            {
                return NotFound();
            }
            return View(projEstudante);
        }

        // POST: ProjEstudante/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeEstudante")] ProjEstudante projEstudante)
        {
            if (id != projEstudante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projEstudante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjEstudanteExists(projEstudante.Id))
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
            return View(projEstudante);
        }

        // GET: ProjEstudante/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProjEstudante == null)
            {
                return NotFound();
            }

            var projEstudante = await _context.ProjEstudante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projEstudante == null)
            {
                return NotFound();
            }

            return View(projEstudante);
        }

        // POST: ProjEstudante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProjEstudante == null)
            {
                return Problem("Entity set 'ProjEscolaContext.ProjEstudante'  is null.");
            }
            var projEstudante = await _context.ProjEstudante.FindAsync(id);
            if (projEstudante != null)
            {
                _context.ProjEstudante.Remove(projEstudante);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjEstudanteExists(int id)
        {
          return _context.ProjEstudante.Any(e => e.Id == id);
        }
    }
}
