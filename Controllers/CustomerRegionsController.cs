using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManufacturaMVC.Models;
using AutoMapper;
using ManufacturaMVC.ViewModels;

namespace ManufacturaMVC.Controllers
{
    public class CustomerRegionsController : Controller
    {
        private readonly ApplicationDbContext _context;        
        private readonly IMapper _mapper;


        public CustomerRegionsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        // GET: CustomerRegions
        public async Task<IActionResult> Index()
        {
            var data = _context.CustomerRegions.Include(c => c.CustomerCountry).ToList();
            List<CustomerCountryRegionVM> ccrList = new List<CustomerCountryRegionVM>();

            foreach (var item in data)
            {
                CustomerCountryRegionVM ccr = new CustomerCountryRegionVM();
                ccr.CustomerRegionId = item.Id;
                ccr.CustomerRegion = item.CustomerRegion;
                ccr.CustomerCountryId = item.CustomerCountryID;
                ccr.CustomerCountry = item.CustomerCountry.ToString();
                ccrList.Add(ccr);
            }
            List <CustomerCountryRegionDto> Regions = _mapper.Map<List<CustomerCountryRegionVM>,
                                                    List<CustomerCountryRegionDto>>(ccrList);
            return View(Regions);
            //return View(await customerRegion.ToListAsync());
        }

        // GET: CustomerRegions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerRegions = await _context.CustomerRegions
                .Include(c => c.CustomerCountry)
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
            ViewData["CustomerCountryID"] = new SelectList(_context.CustomerCountries, "Id", "Id");
            return View();
        }

        // POST: CustomerRegions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerRegion,CustomerCountryID")] CustomerRegions customerRegions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerRegions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerCountryID"] = new SelectList(_context.CustomerCountries, "Id", "Id", customerRegions.CustomerCountryID);
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
            ViewData["CustomerCountryID"] = new SelectList(_context.CustomerCountries, "Id", "Id", customerRegions.CustomerCountryID);
            return View(customerRegions);
        }

        // POST: CustomerRegions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerRegion,CustomerCountryID")] CustomerRegions customerRegions)
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
            ViewData["CustomerCountryID"] = new SelectList(_context.CustomerCountries, "Id", "Id", customerRegions.CustomerCountryID);
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
                .Include(c => c.CustomerCountry)
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
