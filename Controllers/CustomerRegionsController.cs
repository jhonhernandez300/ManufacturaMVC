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
        //public async Task<IActionResult> Index()
        public IActionResult Index()
        {
            List<CustomerCountryRegionVM> countryRegionList = new List<CustomerCountryRegionVM>();

            try
            {
                var regionsWithTheirCountry = (from r in _context.CustomerRegions
                                               join c in _context.CustomerCountries
                                               on r.IdCustomerCountry equals c.IdCustomerCountry
                                               select new
                                               {
                                                   r.IdCustomerRegion,
                                                   r.CustomerRegionName,
                                                   c.IdCustomerCountry,
                                                   c.CustomerCountryName
                                               }).OrderBy(m => m.CustomerCountryName);                

                foreach (var item in regionsWithTheirCountry)
                {
                    CustomerCountryRegionVM countryRegionVM = new CustomerCountryRegionVM();
                    countryRegionVM.IdCustomerRegion = item.IdCustomerRegion;
                    countryRegionVM.CustomerRegionName = item.CustomerRegionName;
                    countryRegionVM.IdCustomerCountry = item.IdCustomerCountry;
                    countryRegionVM.CustomerCountryName = item.CustomerCountryName;
                    countryRegionList.Add(countryRegionVM);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }           

            return View(countryRegionList);            
        }

        // GET: CustomerRegions/Details/5
        public IActionResult Details(int? id)
        {
            CustomerCountryRegionVM countryRegionVM = new CustomerCountryRegionVM();

            if (id == null)
            {
                return NotFound();
            }
            else 
            {
                try
                {
                    var regionsWithTheirCountry = (from r in _context.CustomerRegions
                                                   join c in _context.CustomerCountries
                                                   on r.IdCustomerCountry equals c.IdCustomerCountry
                                                   where r.IdCustomerRegion == id
                                                   select new
                                                   {
                                                       r.IdCustomerRegion,
                                                       r.CustomerRegionName,
                                                       c.IdCustomerCountry,
                                                       c.CustomerCountryName
                                                   }).FirstOrDefault();

                    if (regionsWithTheirCountry == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        countryRegionVM.IdCustomerRegion = regionsWithTheirCountry.IdCustomerRegion;
                        countryRegionVM.CustomerRegionName = regionsWithTheirCountry.CustomerRegionName;
                        countryRegionVM.IdCustomerCountry = regionsWithTheirCountry.IdCustomerCountry;
                        countryRegionVM.CustomerCountryName = regionsWithTheirCountry.CustomerCountryName;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return View(countryRegionVM);
            }
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
                    CustomerRegions region = new CustomerRegions();
                    region.CustomerRegionName = customerCountryRegionVM.CustomerRegionName;
                    region.IdCustomerCountry = customerCountryRegionVM.IdCustomerCountry;

                    _context.Add(region);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }

            ViewData["IdCustomerCountry"] = new SelectList(_context.CustomerCountries, "IdCustomerCountry", "IdCustomerCountry");

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

                    if (customerRegions == null)
                    {
                        return NotFound();
                    }

                    ViewData["IdCustomerCountry"] = new SelectList(_context.CustomerCountries, "IdCustomerCountry", "IdCustomerCountry");

                    return View(customerRegions);
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
        public async Task<IActionResult> Edit(int id, [Bind("IdCustomerRegion,CustomerRegionName,IdCustomerCountry")] CustomerRegions customerRegions)
        {
            if (id != customerRegions.IdCustomerRegion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {                                     
                    var region = _context.CustomerRegions.FirstOrDefault(c => c.IdCustomerRegion == customerRegions.IdCustomerRegion);
                    region.CustomerRegionName = customerRegions.CustomerRegionName;
                    _context.Update(region);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerRegionsExists(customerRegions.IdCustomerRegion))
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

            return View(customerRegions);
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

                    if (customerRegions == null)
                    {
                        return NotFound();
                    }

                    return View(customerRegions);
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
                var customerRegions = await _context.CustomerRegions.FindAsync(id);
                _context.CustomerRegions.Remove(customerRegions);
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
