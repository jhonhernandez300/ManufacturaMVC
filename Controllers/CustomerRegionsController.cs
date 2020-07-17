using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManufacturaMVC.Models;

namespace ManufacturaMVC.Controllers
{
    public class CustomerRegionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerRegionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerRegions
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomerRegions.ToListAsync());
        }

        // GET: CustomerRegions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerRegions = await _context.CustomerRegions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerRegions == null)
            {
                return NotFound();
            }

            return View(customerRegions);
        }

        // GET: CustomerRegions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerRegions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerRegion")] CustomerRegions customerRegions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerRegions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerRegions);
        }

        // GET: CustomerRegions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerRegions = await _context.CustomerRegions.FindAsync(id);
            if (customerRegions == null)
            {
                return NotFound();
            }
            return View(customerRegions);
        }

        // POST: CustomerRegions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerRegion")] CustomerRegions customerRegions)
        {
            if (id != customerRegions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerRegions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerRegionsExists(customerRegions.Id))
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
            return View(customerRegions);
        }

        // GET: CustomerRegions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerRegions = await _context.CustomerRegions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerRegions == null)
            {
                return NotFound();
            }

            return View(customerRegions);
        }

        // POST: CustomerRegions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerRegions = await _context.CustomerRegions.FindAsync(id);
            _context.CustomerRegions.Remove(customerRegions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerRegionsExists(int id)
        {
            return _context.CustomerRegions.Any(e => e.Id == id);
        }
    }
}
