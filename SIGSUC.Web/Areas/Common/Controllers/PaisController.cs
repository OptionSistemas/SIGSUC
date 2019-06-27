using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIGSUC.DAL.Context;
using SIGSUC.Domain.Entities.Common;
using SIGSUC.Domain.Interfaces;

namespace SIGSUC.Web.Areas.Common.Controllers
{
    [Route("api/common/{controller}/{action}")]
    [Area("Common")]
    public class PaisController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PaisController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Common/Pais
        public async Task<IActionResult> Index()
        {
            /*var sIGSUCContext = _context.Paises.Include(p => p.Continente);
            return View(await sIGSUCContext.ToListAsync());*/
            var paises =  await _unitOfWork.Paises.GetAllAsync();
            return View(paises);
        }
        /*
        // GET: Common/Pais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pais = await _context.Paises
                .Include(p => p.Continente)
                .FirstOrDefaultAsync(m => m.PaisId == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }
        */

        // GET: Common/Pais/Create
        public async Task<IActionResult> Create()
        {
            ViewData["ContinenteId"] = new SelectList(await _unitOfWork.Continentes.GetAllAsync(), "ContinenteId", "Descricao");
            return View();
        }

        // POST: Common/Pais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaisId,Nome,CodigoArea,ContinenteId")] Pais pais)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Paises.Add(pais);
                await _unitOfWork.Commit();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContinenteId"] = new SelectList(await _unitOfWork.Continentes.GetAllAsync(), "ContinenteId", "Descricao", pais.ContinenteId);
            return View(pais);
        }

        /*
         * // GET: Common/Pais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pais = await _context.Paises.FindAsync(id);
            if (pais == null)
            {
                return NotFound();
            }
            ViewData["ContinenteId"] = new SelectList(_context.Continentes, "ContinenteId", "Descricao", pais.ContinenteId);
            return View(pais);
        }

        // POST: Common/Pais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PaisId,Nome,CodigoArea,ContinenteId")] Pais pais)
        {
            if (id != pais.PaisId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pais);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaisExists(pais.PaisId))
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
            ViewData["ContinenteId"] = new SelectList(_context.Continentes, "ContinenteId", "Descricao", pais.ContinenteId);
            return View(pais);
        }

        // GET: Common/Pais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pais = await _context.Paises
                .Include(p => p.Continente)
                .FirstOrDefaultAsync(m => m.PaisId == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        // POST: Common/Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pais = await _context.Paises.FindAsync(id);
            _context.Paises.Remove(pais);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaisExists(int id)
        {
            return _context.Paises.Any(e => e.PaisId == id);
        }
        */
    }
}
