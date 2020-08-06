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
            var data = (from r in _context.CustomerRegions
                        join c in _context.CustomerCountries
                        on r.IdCustomerCountry equals c.IdCustomerCountry
                        select new
                        {
                            r.IdCustomerRegion,
                            r.CustomerRegionName,
                            c.IdCustomerCountry,
                            c.CustomerCountryName   
                        }).OrderBy(m => m.CustomerCountryName);            

            /*var data2 = _context.CustomerRegions.Include("CustomerContry.CustomerCountryName").FirstOrDefault();

            List<CustomerCountryRegionVM> regionsWithCountries = _mapper.Map<List<CustomerRegions>,
                                                    List<CustomerCountryRegionVM>>(data2); */
            /*No se puede convertir de CustomerRegions a Generic list CustomerCountryRegionVM
             
             data. No se puede convertir de Order Iqueryable a generic list
            */            

            List<CustomerCountryRegionVM> ccrList = new List<CustomerCountryRegionVM>();

            foreach (var item in data)
            {
                CustomerCountryRegionVM ccr = new CustomerCountryRegionVM();
                ccr.IdCustomerRegion = item.IdCustomerRegion;
                ccr.CustomerRegionName = item.CustomerRegionName;
                ccr.IdCustomerCountry = item.IdCustomerCountry;
                ccr.CustomerCountryName = item.CustomerCountryName;
                ccrList.Add(ccr);
            }            

            return View(ccrList);            
        }

        // GET: CustomerRegions/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else 
            {
                //var customerRegions = await _context.CustomerRegions.Include(c => c.CustomerCountry)
                //                                                  .FirstOrDefaultAsync(m => m.IdCustomerRegion == id);
                var customerRegions = (from r in _context.CustomerRegions
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

                if (customerRegions == null)
                {
                    return NotFound();
                }
                else
                {
                    CustomerCountryRegionVM ccr = new CustomerCountryRegionVM();
                    ccr.IdCustomerRegion = customerRegions.IdCustomerRegion;
                    ccr.CustomerRegionName = customerRegions.CustomerRegionName;
                    ccr.IdCustomerCountry = customerRegions.IdCustomerCountry;
                    ccr.CustomerCountryName = customerRegions.CustomerCountryName;

                    //var model = _mapper.Map<CustomerCountryRegionVM, CustomerRegionsDto>(ccr);

                    //var model = _mapper.Map<CustomerRegions, CustomerRegionsDto>(customerRegions);

                    return View(ccr);
                }
            }
        }

        // GET: CustomerRegions/Create
        public IActionResult Create()
        {
            //ViewData["IdCustomerCountry"] = new SelectList(_context.CustomerCountries, "IdCustomerCountry", "IdCustomerCountry");
            ViewData["CustomerCountryName"] = new SelectList(_context.CustomerCountries, "IdCustomerCountry", "CustomerCountryName");
            return View();
        }

        // POST: CustomerRegions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCustomerRegion,CustomerRegionName,IdCustomerCountry")] CustomerCountryRegionVM customerCountryRegionVM)
        //public async Task<IActionResult> Create(CustomerCountryRegionVM customerCountryRegionVM)
        {
            if (ModelState.IsValid)
            {
                //var region = _mapper.Map<CustomerRegionsDto, CustomerCountryRegionVM>(customerRegionsDto);
                CustomerRegions region = new CustomerRegions();
                region.CustomerRegionName = customerCountryRegionVM.CustomerRegionName;
                region.IdCustomerCountry = customerCountryRegionVM.IdCustomerCountry;                

                _context.Add(region);   
                await _context.SaveChangesAsync(); 
                
                return RedirectToAction(nameof(Index));
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

            var customerRegions = await _context.CustomerRegions.FindAsync(id);
            if (customerRegions == null)
            {
                return NotFound();
            }
            ViewData["CustomerCountryID"] = new SelectList(_context.CustomerCountries, "Id", "Id", customerRegions.IdCustomerCountry);
            return View(customerRegions);
        }

        // POST: CustomerRegions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerRegion,CustomerCountryID")] CustomerRegions customerRegions)
        {
            if (id != customerRegions.IdCustomerRegion)
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
            ViewData["CustomerCountryID"] = new SelectList(_context.CustomerCountries, "Id", "Id", customerRegions.IdCustomerCountry);
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
                .FirstOrDefaultAsync(m => m.IdCustomerCountry == id);
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
            return _context.CustomerRegions.Any(e => e.IdCustomerRegion == id);
        }
    }
}
