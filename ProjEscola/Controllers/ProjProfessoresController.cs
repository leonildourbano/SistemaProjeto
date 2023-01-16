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
    public class ProjProfessoresController : Controller
    {
        private readonly ProjEscolaContext _context;

        public ProjProfessoresController(ProjEscolaContext context)
        {
            _context = context;
        }

        // GET: ProjProfessores
        public async Task<IActionResult> Index()
        {
              return View(await _context.ProjProfessor.ToListAsync());
        }

        // GET: ProjProfessores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProjProfessor == null)
            {
                return NotFound();
            }

            var projProfessor = await _context.ProjProfessor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projProfessor == null)
            {
                return NotFound();
            }

            return View(projProfessor);
        }

        // GET: ProjProfessores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjProfessores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeProfessor,EmailProfessor,ValorHoraProfessor,DisponibilidadeHorarioProfessor,CertificadosProfessor")] ProjProfessor projProfessor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projProfessor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projProfessor);
        }

        // GET: ProjProfessores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProjProfessor == null)
            {
                return NotFound();
            }

            var projProfessor = await _context.ProjProfessor.FindAsync(id);
            if (projProfessor == null)
            {
                return NotFound();
            }
            return View(projProfessor);
        }

        // POST: ProjProfessores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeProfessor,EmailProfessor,ValorHoraProfessor,DisponibilidadeHorarioProfessor,CertificadosProfessor")] ProjProfessor projProfessor)
        {
            if (id != projProfessor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projProfessor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjProfessorExists(projProfessor.Id))
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
            return View(projProfessor);
        }

        // GET: ProjProfessores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProjProfessor == null)
            {
                return NotFound();
            }

            var projProfessor = await _context.ProjProfessor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projProfessor == null)
            {
                return NotFound();
            }

            return View(projProfessor);
        }

        // POST: ProjProfessores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProjProfessor == null)
            {
                return Problem("Entity set 'ProjEscolaContext.ProjProfessor'  is null.");
            }
            var projProfessor = await _context.ProjProfessor.FindAsync(id);
            if (projProfessor != null)
            {
                _context.ProjProfessor.Remove(projProfessor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjProfessorExists(int id)
        {
          return _context.ProjProfessor.Any(e => e.Id == id);
        }
    }
}
