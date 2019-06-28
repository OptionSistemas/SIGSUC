using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIGSUC.Domain.Entities.Common;
using SIGSUC.Domain.Interfaces;
using System.Threading.Tasks;

namespace SIGSUC.Web.Areas.Common.Controllers
{
    [Area("Common")]
    [Route("api/common/[controller]/{action}/{id?}")]
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


        // GET: Common/Pais/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pais = await _unitOfWork.Paises.GetAsync(id);
            if (pais == null)
            {
                return NotFound();
            }
            ViewData["ContinenteId"] = new SelectList(await _unitOfWork.Continentes.GetAllAsync(), "ContinenteId", "Descricao", pais.ContinenteId);
            return View(pais);
        }

        // POST: Common/Pais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int id, [Bind("PaisId,Nome,CodigoArea,ContinenteId")] Pais pais)
            {
            if (id != pais.PaisId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.Paises.Update(pais);
                    await _unitOfWork.Commit(); 
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
            ViewData["ContinenteId"] = new SelectList(await _unitOfWork.Continentes.GetAllAsync(), "ContinenteId", "Descricao", pais.ContinenteId);
            return View(pais);
        }

         // GET: Common/Pais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pais = await _unitOfWork.Paises.GetAsync(id);
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
            var pais = await _unitOfWork.Paises.GetAsync(id);
            _unitOfWork.Paises.Remove(pais);
            await _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }


        private bool PaisExists(int id)
        {
            return (_unitOfWork.Paises.Find(e => e.PaisId == id) != null);
        }
    }
}
