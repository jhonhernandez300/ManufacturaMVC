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
    public class CustomerCountriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CustomerCountriesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: CustomerCountries
        public async Task<IActionResult> Index()        
        {
            //CustomerCountries customerCountry = new CustomerCountries();
            var customerCountry = await _context.CustomerCountries.ToListAsync();            
            List<CustomerCountriesDto> countries = _mapper.Map<List<CustomerCountries>, 
                                                    List<CustomerCountriesDto>>(await _context.CustomerCountries.ToListAsync());
         
            return View(countries);
        }

        // GET: CustomerCountries/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCountries = await _context.CustomerCountries
                .FirstOrDefaultAsync(m => m.CustomerCountry == id);
            if (customerCountries == null)
            {
                return NotFound();
            }

            return View(customerCountries);
        }

        // GET: CustomerCountries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerCountries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerCountry")] CustomerCountries customerCountries)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerCountries);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerCountries);
            /*var weatherReport = _mapper.Map<WeatherReportCreateView, WeatherReport>(WeatherReport);
            _context.WeatherReport.Add(weatherReport);
            await _context.SaveChangesAsync(); */
        }

        // GET: CustomerCountries/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCountries = await _context.CustomerCountries.FindAsync(id);
            if (customerCountries == null)
            {
                return NotFound();
            }
            return View(customerCountries);
        }

        // POST: CustomerCountries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CustomerCountry")] CustomerCountries customerCountries)
        {
            if (id != customerCountries.CustomerCountry)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerCountries);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerCountriesExists(customerCountries.CustomerCountry))
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
            return View(customerCountries);
        }

        // GET: CustomerCountries/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCountries = await _context.CustomerCountries
                .FirstOrDefaultAsync(m => m.CustomerCountry == id);
            if (customerCountries == null)
            {
                return NotFound();
            }

            return View(customerCountries);
        }

        // POST: CustomerCountries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var customerCountries = await _context.CustomerCountries.FindAsync(id);
            _context.CustomerCountries.Remove(customerCountries);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerCountriesExists(string id)
        {
            return _context.CustomerCountries.Any(e => e.CustomerCountry == id);
        }
    }
}
