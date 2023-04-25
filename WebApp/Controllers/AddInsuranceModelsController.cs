using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AddInsuranceModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddInsuranceModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AddInsuranceModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.AddInsuranceModel.ToListAsync());
        }

        // GET: AddInsuranceModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AddInsuranceModel == null)
            {
                return NotFound();
            }

            var addInsuranceModel = await _context.AddInsuranceModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (addInsuranceModel == null)
            {
                return NotFound();
            }

            return View(addInsuranceModel);
        }

        // GET: AddInsuranceModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AddInsuranceModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TypPojisteni,Castka,Predmet,PlatnostOd,PlatnostDo")] AddInsuranceModel addInsuranceModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addInsuranceModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addInsuranceModel);
        }

        // GET: AddInsuranceModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AddInsuranceModel == null)
            {
                return NotFound();
            }

            var addInsuranceModel = await _context.AddInsuranceModel.FindAsync(id);
            if (addInsuranceModel == null)
            {
                return NotFound();
            }
            return View(addInsuranceModel);
        }

        // POST: AddInsuranceModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TypPojisteni,Castka,Predmet,PlatnostOd,PlatnostDo")] AddInsuranceModel addInsuranceModel)
        {
            if (id != addInsuranceModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addInsuranceModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddInsuranceModelExists(addInsuranceModel.ID))
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
            return View(addInsuranceModel);
        }

        // GET: AddInsuranceModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AddInsuranceModel == null)
            {
                return NotFound();
            }

            var addInsuranceModel = await _context.AddInsuranceModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (addInsuranceModel == null)
            {
                return NotFound();
            }

            return View(addInsuranceModel);
        }

        // POST: AddInsuranceModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AddInsuranceModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.AddInsuranceModel'  is null.");
            }
            var addInsuranceModel = await _context.AddInsuranceModel.FindAsync(id);
            if (addInsuranceModel != null)
            {
                _context.AddInsuranceModel.Remove(addInsuranceModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddInsuranceModelExists(int id)
        {
          return _context.AddInsuranceModel.Any(e => e.ID == id);
        }
    }
}
