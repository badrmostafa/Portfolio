using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class AddressController : Controller
    {
        private readonly IUnitOfWork<Address> address;

        public AddressController(IUnitOfWork<Address> address)
        {
            this.address = address;
        }
        public IActionResult Index()
        {
            return View(address.Entity.AllData().ToList());
        }
        [HttpGet]
        public IActionResult Index(string searchAddress, string sortOrder, string currentFilter,int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["Country"] = string.IsNullOrEmpty(sortOrder) ? "country_desc" : "";
            ViewData["City"] = sortOrder == "City" ? "city_asc" : "city_desc";

            if (searchAddress != null)
                pageNumber = 1;
            else
                searchAddress = currentFilter;
            ViewData["CurrentFilter"] = searchAddress;

            var addressQuery = from a in address.Entity.AllData() select a;
            if(!string.IsNullOrEmpty(searchAddress))
            {
                addressQuery = addressQuery.Where(a => a.Country.Contains(searchAddress) || a.City.Contains(searchAddress));
            }
            switch (sortOrder)
            {
                case "country_desc":
                    addressQuery = addressQuery.OrderByDescending(a => a.Country);
                    break;
                case "city_asc":
                    addressQuery = addressQuery.OrderBy(a => a.City);
                    break;
                case "city_desc":
                    addressQuery = addressQuery.OrderByDescending(a => a.City);
                    break;
                default:
                    addressQuery = addressQuery.OrderBy(a => a.Country);
                    break;
            }
            int pageSize = 2;
            return View(PaginatedList<Address>.Create(addressQuery,pageNumber??1,pageSize));
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();
            Address a = address.Entity.GetById(id??0);
            if (a == null)
                return NotFound();
            return View(a);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Address a)
        {
            if(ModelState.IsValid)
            {
                address.Entity.Create(a);
                address.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
        [HttpGet]
        public IActionResult Edit(int?  id)
        {
            return Details(id);
        }
        [HttpPost]
        public IActionResult Edit(Address a)
        {
            if(ModelState.IsValid)
            {
                address.Entity.Edit(a);
                address.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            return Details(id);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            var a = address.Entity.GetById(id ?? 0);
            if(a != null)
            {
                address.Entity.Delete(id ?? 0);
                address.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}
