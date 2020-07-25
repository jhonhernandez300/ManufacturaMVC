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
    public class CustomerCitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerCitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerCities
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomerCities.ToListAsync());
        }

        // GET: CustomerCities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCities = await _context.CustomerCities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerCities == null)
            {
                return NotFound();
            }

            return View(customerCities);
        }

        // GET: CustomerCities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerCities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerCity,PostalCode")] CustomerCities customerCities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerCities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerCities);
        }

        // GET: CustomerCities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCities = await _context.CustomerCities.FindAsync(id);
            if (customerCities == null)
            {
                return NotFound();
            }
            return View(customerCities);
        }

        // POST: CustomerCities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerCity,PostalCode")] CustomerCities customerCities)
        {
            if (id != customerCities.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerCities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerCitiesExists(customerCities.Id))
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
            return View(customerCities);
        }

        // GET: CustomerCities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCities = await _context.CustomerCities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerCities == null)
            {
                return NotFound();
            }

            return View(customerCities);
        }

        // POST: CustomerCities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerCities = await _context.CustomerCities.FindAsync(id);
            _context.CustomerCities.Remove(customerCities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerCitiesExists(int id)
        {
            return _context.CustomerCities.Any(e => e.Id == id);
        }
    }
}
