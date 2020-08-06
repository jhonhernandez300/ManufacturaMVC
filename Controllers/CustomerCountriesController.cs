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
using ManufacturaMVC.Dto;

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
            var customerCountry = await _context.CustomerCountries.ToListAsync();
            List<CustomerCountriesDto> countries = _mapper.Map<List<CustomerCountries>,
                                                    List<CustomerCountriesDto>>(await _context.CustomerCountries.ToListAsync());

            return View(countries);

        }

        // GET: CustomerCountries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCountries = await _context.CustomerCountries.FirstOrDefaultAsync(m => m.IdCustomerCountry == id);

            if (customerCountries == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<CustomerCountries, CustomerCountriesDto>(customerCountries);

            //return View(customerCountries);
            return View(model);
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
        public async Task<IActionResult> Create(CustomerCountriesDto customerCountriesDto)
        {
            if (ModelState.IsValid)
            {
                var customer = _mapper.Map<CustomerCountriesDto, CustomerCountries>(customerCountriesDto);
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        // GET: CustomerCountries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var customerCountries = await _context.CustomerCountries.FindAsync(id);
            var model = _mapper.Map<CustomerCountries, CustomerCountriesDto>(customerCountries);

            if (customerCountries == null)
            {
                return NotFound();
            }

            return View(model);
            //return View(customerCountries);
        }

        // POST: CustomerCountries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, CustomerCountriesDto customerCountriesDto)
        {
            if (Id != customerCountriesDto.IdCustomerCountry)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {                    
                    var CustomerCountries = _mapper.Map<CustomerCountriesDto, CustomerCountries>(customerCountriesDto);
                    var country = _context.CustomerCountries.FirstOrDefault(c => c.IdCustomerCountry == CustomerCountries.IdCustomerCountry);
                    country.CustomerCountryName = customerCountriesDto.CustomerCountryName;
                    _context.Update(country);
                    await _context.SaveChangesAsync();                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerCountriesExists(customerCountriesDto.IdCustomerCountry))
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
            return View(customerCountriesDto);
        }

        // GET: CustomerCountries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCountries = await _context.CustomerCountries.FirstOrDefaultAsync(m => m.IdCustomerCountry == id);
            var model = _mapper.Map<CustomerCountries, CustomerCountriesDto>(customerCountries);

            if (customerCountries == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: CustomerCountries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, CustomerCountriesDto customerCountriesDto)
        {
            var CustomerCountries = _mapper.Map<CustomerCountriesDto, CustomerCountries>(customerCountriesDto);
            var customerCountries = await _context.CustomerCountries.FindAsync(id);
            _context.CustomerCountries.Remove(customerCountries);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerCountriesExists(int id)
        {
            return _context.CustomerCountries.Any(e => e.IdCustomerCountry == id);
        }
    }
}
