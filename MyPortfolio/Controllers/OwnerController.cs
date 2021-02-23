using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPortfolio.Models;
using MyPortfolio.IUnitOfWork;
using MyPortfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class OwnerController : Controller
    {
        private readonly IUnitOfWork<Owner> owner;
        private readonly IUnitOfWork<Address> address;
        private readonly IWebHostEnvironment web;
        private readonly IUnitOfWork<OwnerAddressViewModel> oavm;

        public OwnerController(IUnitOfWork<Owner> owner,IUnitOfWork<Address> address,IWebHostEnvironment web,IUnitOfWork<OwnerAddressViewModel> oavm)
        {
            this.owner = owner;
            this.address = address;
            this.web = web;
            this.oavm = oavm;
        }
        
        public IActionResult Index()
        {
            OwnerAddressViewModel ownerAddressViewModel = new OwnerAddressViewModel()
            {
                Owners = owner.Entity.AllData().ToList(),
                Addresses = address.Entity.AllData().ToList()
            };
            return View(ownerAddressViewModel);
        }
        [HttpGet]
        public IActionResult Index(string searchOwner, string sortOrder, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["OwnerName"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["Profile"] = sortOrder == "Profile" ? "profile_desc" : "profile_asc";
            ViewData["City"] = sortOrder == "City" ? "city_asc" : "city_desc";
            if (searchOwner != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchOwner = currentFilter;
            }
            ViewData["CurrentFilter"] = searchOwner;
            var ownerQuery = from o in owner.Entity.AllData() select o;
            var addressQuery = from a in address.Entity.AllData() select a;
            if (!string.IsNullOrEmpty(searchOwner))
            {
                ownerQuery = ownerQuery.Where(o => o.OwnerName.Contains(searchOwner) || o.Profile.Contains(searchOwner) ||
                o.Address.City.Contains(searchOwner));
            }
            OwnerAddressViewModel model = new OwnerAddressViewModel()
            {
                Owners = ownerQuery.ToList()
            };
            switch (sortOrder)
            {
                case "name_desc":
                    model.Owners = model.Owners.OrderByDescending(m => m.OwnerName).ToList();
                    break;
                case "profile_desc":
                    model.Owners = model.Owners.OrderByDescending(m => m.Profile).ToList();
                    break;
                case "profile_asc":
                    model.Owners = model.Owners.OrderBy(m => m.Profile).ToList();
                    break;
                case "city_asc":
                    model.Owners = model.Owners.OrderBy(m => m.Address.City).ToList();
                    break;
                case "city_desc":
                    model.Owners = model.Owners.OrderByDescending(m => m.Address.City).ToList();
                    break;
                default:
                    model.Owners = model.Owners.OrderBy(m => m.OwnerName).ToList();
                    break;
            }
            int pageSize = 2;
            List<Owner> owners = new List<Owner>();
            owners = model.Owners.ToList();
            return View(PaginatedList<Owner>.Create(owners, pageNumber??1, pageSize));
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();
            Owner o = owner.Entity.GetById(id??0);
            if (o == null)
                return NotFound();
            return View(o);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AddressId = new SelectList(address.Entity.AllData(), "Id", "Id");
            return View();
        }
        [HttpPost]
        public IActionResult Create(OwnerViewModel model)
        {
            if(ModelState.IsValid)
            {
                UploadImage(model);
                Owner o = new Owner()
                {
                    Id = model.Id,
                    OwnerName = model.OwnerName,
                    Profile = model.Profile,
                    Image = model.File.FileName,
                    AddressId = model.AddressId
                };
                owner.Entity.Create(o);
                owner.Save();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");                     
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();
            Owner o = owner.Entity.GetById(id ?? 0);
            if (o == null)
                return NotFound();
            ViewBag.AddressId = new SelectList(owner.Entity.AllData(), "Id", "AddressId");
            OwnerViewModel ownerViewModel = new OwnerViewModel()
            {
                Id = o.Id,
                Image = o.Image,
                OwnerName = o.OwnerName,
                Profile = o.Profile,
                AddressId = o.AddressId
            };
            return View(ownerViewModel);
        }
        [HttpPost]
        public IActionResult Edit(OwnerViewModel model)
        {
            if(ModelState.IsValid)
            {
                UploadImage(model);
                Owner o = new Owner()
                {
                    Id = model.Id,
                    OwnerName = model.OwnerName,
                    Image = model.File.FileName,
                    Profile = model.Profile,
                    AddressId = model.AddressId
                };
                owner.Entity.Edit(o);
                owner.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            Owner o = owner.Entity.GetById(id ?? 0);
            if (o == null)
                return NotFound();
            
            return View(o);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            var o = owner.Entity.GetById(id ?? 0);
            if(o != null)
            {
                owner.Entity.Delete(id ?? 0);
                owner.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }



        public void UploadImage(OwnerViewModel ownerViewModel)
        {
            if (ownerViewModel.File != null)
            {
                string upload = Path.Combine(web.WebRootPath, @"assets\img");
                string fullPath = Path.Combine(upload, ownerViewModel.File.FileName);
                FileStream fileStream = new FileStream(fullPath, FileMode.Create);
                ownerViewModel.File.CopyTo(fileStream);
            }
        }
    }
}
