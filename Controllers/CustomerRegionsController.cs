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
using ManufacturaMVC.Migrations;

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
            try
            {
                var customerRegions = await _context.CustomerRegions
                .Include(c => c.CustomerCountry)
                .ToListAsync();
                
                List<CustomerCountryRegionVM> regions = _mapper.Map<List<CustomerRegions>,
                                                        List<CustomerCountryRegionVM>>(customerRegions);
          
                return View(regions);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return NotFound();
            }                       
        }

        // GET: CustomerRegions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = await _context.CustomerRegions
                .Include(c => c.CustomerCountry)
                .FirstOrDefaultAsync(m => m.IdCustomerRegion == id);

            if (data == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<CustomerRegions, CustomerCountryRegionVM>(data);
            
            return View(model);
        }

        // GET: CustomerRegions/Create
        public IActionResult Create()
        {            
            ViewData["CustomerCountryName"] = new SelectList(_context.CustomerCountries, "IdCustomerCountry", "CustomerCountryName");

            return View();
        }

        // POST: CustomerRegions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCustomerRegion,CustomerRegionName,IdCustomerCountry")] CustomerCountryRegionVM customerCountryRegionVM)        
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var data = _mapper.Map<CustomerCountryRegionVM, CustomerRegions>(customerCountryRegionVM);
                    _context.Add(data);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }

            ViewData["IdCustomerCountry"] = new SelectList(_context.CustomerCountries, "IdCustomerCountry", "CustomerCountryName");

            return View(customerCountryRegionVM);
        }
        

        // GET: CustomerRegions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    var customerRegions = await _context.CustomerRegions.FindAsync(id);
                    var model = _mapper.Map<CustomerRegions, CustomerCountryRegionVM>(customerRegions);

                    if (customerRegions == null)
                    {
                        return NotFound();
                    }

                    ViewData["CustomerCountryName"] = new SelectList(_context.CustomerCountries, "IdCustomerCountry", "CustomerCountryName");

                    return View(model);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return NotFound();                    
                }
            }
        }

        // POST: CustomerRegions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCustomerRegion,CustomerRegionName,IdCustomerCountry")] CustomerCountryRegionVM customerCountryRegionVM)
        {            
            if (id != customerCountryRegionVM.IdCustomerRegion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var data = _mapper.Map<CustomerCountryRegionVM, CustomerRegions>(customerCountryRegionVM);
                    var region = _context.CustomerRegions.FirstOrDefault(c => c.IdCustomerRegion == data.IdCustomerRegion);
                    region.CustomerRegionName = customerCountryRegionVM.CustomerRegionName;
                    _context.Update(region);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerRegionsExists(customerCountryRegionVM.IdCustomerRegion))
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

            ViewData["IdCustomerCountry"] = new SelectList(_context.CustomerCountries, "IdCustomerCountry", "IdCustomerCountry");

            return View(customerCountryRegionVM);
        }

        // GET: CustomerRegions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    var customerRegions = await _context.CustomerRegions
                            .Include(c => c.CustomerCountry)
                            .FirstAsync(m => m.IdCustomerRegion == id);
                    var model = _mapper.Map<CustomerRegions, CustomerCountryRegionVM>(customerRegions);
                    ViewData["CustomerCountryName"] = new SelectList(_context.CustomerCountries, "IdCustomerCountry", "CustomerCountryName");

                    if (customerRegions == null)
                    {
                        return NotFound();
                    }

                    return View(model);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return NotFound();
                }

            }            
        }

        // POST: CustomerRegions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                //var regions = _mapper.Map<CustomerCountryRegionVM, CustomerRegions>(customerCountryRegionVM);
                var data = await _context.CustomerRegions.FindAsync(id);
                _context.CustomerRegions.Remove(data);
                await _context.SaveChangesAsync();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);               
            }

            return RedirectToAction(nameof(Index));
        }

        private bool CustomerRegionsExists(int id)
        {
            var regions = false;

            try
            {
                regions = _context.CustomerRegions.Any(e => e.IdCustomerRegion == id);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
            return regions;
        }

    }
}
