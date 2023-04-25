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
    public class NewInsuredModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewInsuredModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NewInsuredModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewInsuredModel.ToListAsync());

        }

        // GET: NewInsuredModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.NewInsuredModel == null)
            {
                return NotFound();
            }

            var newInsuredModel = await _context.NewInsuredModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (newInsuredModel == null)
            {
                return NotFound();
            }

            return View(newInsuredModel);
        }

        // GET: NewInsuredModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewInsuredModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Jmeno,Prijmeni,Email,Telefon,Ulice,Mesto,PSC")] NewInsuredModel newInsuredModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newInsuredModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newInsuredModel);
        }

        // GET: NewInsuredModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NewInsuredModel == null)
            {
                return NotFound();
            }

            var newInsuredModel = await _context.NewInsuredModel.FindAsync(id);
            if (newInsuredModel == null)
            {
                return NotFound();
            }
            return View(newInsuredModel);
        }

        // POST: NewInsuredModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Jmeno,Prijmeni,Email,Telefon,Ulice,Mesto,PSC")] NewInsuredModel newInsuredModel)
        {
            if (id != newInsuredModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newInsuredModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewInsuredModelExists(newInsuredModel.ID))
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
            return View(newInsuredModel);
        }

        // GET: NewInsuredModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.NewInsuredModel == null)
            {
                return NotFound();
            }

            var newInsuredModel = await _context.NewInsuredModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (newInsuredModel == null)
            {
                return NotFound();
            }

            return View(newInsuredModel);
        }

        // POST: NewInsuredModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.NewInsuredModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NewInsuredModel'  is null.");
            }
            var newInsuredModel = await _context.NewInsuredModel.FindAsync(id);
            if (newInsuredModel != null)
            {
                _context.NewInsuredModel.Remove(newInsuredModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewInsuredModelExists(int id)
        {
          return _context.NewInsuredModel.Any(e => e.ID == id);
        }
    }
}
