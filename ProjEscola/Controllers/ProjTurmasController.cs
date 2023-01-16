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
    public class ProjTurmasController : Controller
    {
        private readonly ProjEscolaContext _context;

        public ProjTurmasController(ProjEscolaContext context)
        {
            _context = context;
        }

        // GET: ProjTurmas
        public async Task<IActionResult> Index()
        {
              return View(await _context.ProjTurma.ToListAsync());
        }

        // GET: ProjTurmas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProjTurma == null)
            {
                return NotFound();
            }

            var projTurma = await _context.ProjTurma
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projTurma == null)
            {
                return NotFound();
            }

            return View(projTurma);
        }

        // GET: ProjTurmas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjTurmas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeTurma,DataInicioTurma,DataTerminoTurma,TipoTurma,HorarioTurma")] ProjTurma projTurma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projTurma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projTurma);
        }

        // GET: ProjTurmas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProjTurma == null)
            {
                return NotFound();
            }

            var projTurma = await _context.ProjTurma.FindAsync(id);
            if (projTurma == null)
            {
                return NotFound();
            }
            return View(projTurma);
        }

        // POST: ProjTurmas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeTurma,DataInicioTurma,DataTerminoTurma,TipoTurma,HorarioTurma")] ProjTurma projTurma)
        {
            if (id != projTurma.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projTurma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjTurmaExists(projTurma.Id))
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
            return View(projTurma);
        }

        // GET: ProjTurmas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProjTurma == null)
            {
                return NotFound();
            }

            var projTurma = await _context.ProjTurma
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projTurma == null)
            {
                return NotFound();
            }

            return View(projTurma);
        }

        // POST: ProjTurmas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProjTurma == null)
            {
                return Problem("Entity set 'ProjEscolaContext.ProjTurma'  is null.");
            }
            var projTurma = await _context.ProjTurma.FindAsync(id);
            if (projTurma != null)
            {
                _context.ProjTurma.Remove(projTurma);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjTurmaExists(int id)
        {
          return _context.ProjTurma.Any(e => e.Id == id);
        }
    }
}
