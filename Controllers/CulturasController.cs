using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MC_MZ_PF.Data;
using ProyectoFinal_Cartagena_Zumarraga.Models;

namespace MC_MZ_PF.Controllers
{
    public class CulturasController : Controller
    {
        private readonly MC_MZ_PFContext _context;

        public CulturasController(MC_MZ_PFContext context)
        {
            _context = context;
        }

        // GET: Culturas
        public async Task<IActionResult> Index()
        {
              return _context.Cultura != null ? 
                          View(await _context.Cultura.ToListAsync()) :
                          Problem("Entity set 'MC_MZ_PFContext.Cultura'  is null.");
        }

        // GET: Culturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cultura == null)
            {
                return NotFound();
            }

            var cultura = await _context.Cultura
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cultura == null)
            {
                return NotFound();
            }

            return View(cultura);
        }

        // GET: Culturas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Culturas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AsuntoCul,CuerpoCul,FechaCul")] Cultura cultura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cultura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cultura);
        }

        // GET: Culturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cultura == null)
            {
                return NotFound();
            }

            var cultura = await _context.Cultura.FindAsync(id);
            if (cultura == null)
            {
                return NotFound();
            }
            return View(cultura);
        }

        // POST: Culturas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AsuntoCul,CuerpoCul,FechaCul")] Cultura cultura)
        {
            if (id != cultura.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cultura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CulturaExists(cultura.Id))
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
            return View(cultura);
        }

        // GET: Culturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cultura == null)
            {
                return NotFound();
            }

            var cultura = await _context.Cultura
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cultura == null)
            {
                return NotFound();
            }

            return View(cultura);
        }

        // POST: Culturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cultura == null)
            {
                return Problem("Entity set 'MC_MZ_PFContext.Cultura'  is null.");
            }
            var cultura = await _context.Cultura.FindAsync(id);
            if (cultura != null)
            {
                _context.Cultura.Remove(cultura);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CulturaExists(int id)
        {
          return (_context.Cultura?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
