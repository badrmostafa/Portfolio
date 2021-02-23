using Microsoft.AspNetCore.Mvc;
using MyPortfolio.IUnitOfWork;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        private readonly IUnitOfWork<About> about;

        public AboutController(IUnitOfWork<About> about)
        {
            this.about = about;
        }
        
        public IActionResult Index()
        {
            return View(about.Entity.AllData().ToList());
        }
        [HttpGet]
        
        public IActionResult Index(string searchAbout, string sortOrder,string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["Description"] = string.IsNullOrEmpty(sortOrder) ? "description_desc" : "";
            if (searchAbout != null)
                pageNumber = 1;
            else
                searchAbout = currentFilter;
            ViewData["CurrentFilter"] = searchAbout;
            var aboutQuery = from a in about.Entity.AllData() select a;
            if(!string.IsNullOrEmpty(searchAbout))
                aboutQuery = aboutQuery.Where(a => a.Description.Contains(searchAbout));
            switch (sortOrder)
            {
                case "description_desc":
                    aboutQuery = aboutQuery.OrderByDescending(a => a.Description);
                    break;
                default:
                    aboutQuery = aboutQuery.OrderBy(a => a.Description);
                    break;
            }
            int pageSize = 2;
            return View(PaginatedList<About>.Create(aboutQuery,pageNumber??1,pageSize)); 
        }
        
        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();
            var a = about.Entity.GetById(id ?? 0);
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
        [ValidateAntiForgeryToken]
        public IActionResult Create(About a)
        {
            if(ModelState.IsValid)
            {
                about.Entity.Create(a);
                about.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
        [HttpGet]
      
        public IActionResult Edit(int? id)
        {
            return Details(id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(About a)
        {
            if(ModelState.IsValid)
            {
                about.Entity.Edit(a);
                about.Save();
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
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            var a = about.Entity.GetById(id ?? 0);
            if(a != null)
            {
                about.Entity.Delete(id ?? 0);
                about.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

    }
}
