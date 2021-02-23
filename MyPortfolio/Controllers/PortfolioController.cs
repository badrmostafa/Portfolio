using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
    public class PortfolioController : Controller
    {
        private readonly IUnitOfWork<Portfolio> p;
        private readonly IWebHostEnvironment web;
        public PortfolioController(IUnitOfWork<Portfolio> p, IWebHostEnvironment web)
        {
            this.p = p;
            this.web = web;
        }
        public IActionResult Index()
        {
            IEnumerable<Portfolio> portfolios = p.Entity.AllData().ToList();
            return View(portfolios);
        }
        [HttpGet]
        public IActionResult Index(string searchData, string sortOrder,string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["ProjectName"] = string.IsNullOrEmpty(sortOrder) ? "pn_desc" : "";
            ViewData["Description"] = sortOrder == "Description" ? "d_desc" : "d_asc";
            if(searchData != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchData = currentFilter;
            }
            ViewData["CurrentFilter"] = searchData;
            var listQuery = from portfolio in p.Entity.AllData()
                            select portfolio;
            if(!string.IsNullOrEmpty(searchData))
            {
                listQuery = listQuery.Where(p => p.ProjectName.Contains(searchData) || p.Description.Contains(searchData));
            }

            switch (sortOrder)
            {
                case "pn_desc":
                    listQuery = listQuery.OrderByDescending(l => l.ProjectName);
                    break;
                case "d_desc":
                    listQuery = listQuery.OrderByDescending(l => l.Description);
                    break;
                case "d_asc":
                    listQuery = listQuery.OrderBy(l => l.Description);
                    break;
                default:
                    listQuery = listQuery.OrderBy(l => l.ProjectName);
                    break;
            }
            int pageSize = 2;
            return View(PaginatedList<Portfolio>.Create(listQuery,pageNumber??1,pageSize));
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();
            Portfolio portfolio = p.Entity.GetById(id ?? 0);
            if (portfolio == null)
                return NotFound();
            return View(portfolio);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PortfolioViewModel model)
        {
            if (ModelState.IsValid)
            {
                UploadImage(model);
                Portfolio portfolio = new Portfolio()
                {
                    ProjectName = model.ProjectName,
                    Image = model.File.FileName,
                    Description = model.Description
                };
                p.Entity.Create(portfolio);
                p.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();
            Portfolio portfolio = p.Entity.GetById(id ?? 0);
            if (portfolio == null)
                return NotFound();
            PortfolioViewModel portfolioViewModel = new PortfolioViewModel()
            {
                Id = portfolio.Id,
                ProjectName = portfolio.ProjectName,
                Image = portfolio.Image,
                Description = portfolio.Description
            };
            return View(portfolioViewModel);
        }
        [HttpPost]
        public IActionResult Edit(PortfolioViewModel model)
        {
            if (ModelState.IsValid)
            {
                UploadImage(model);
                Portfolio portfolio = new Portfolio()
                {
                    Id = model.Id,
                    ProjectName = model.ProjectName,
                    Image = model.File.FileName,
                    Description = model.Description
                };
                p.Entity.Edit(portfolio);
                p.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            Portfolio portfolio = p.Entity.GetById(id ?? 0);
            if (portfolio == null)
                return NotFound();
            
            return View(portfolio);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
           var portfolio = p.Entity.GetById(id??0);
            if(portfolio != null)
            {
                p.Entity.Delete(id??0);
                p.Save();
            }
            return RedirectToAction("Index");
        }




        public void UploadImage(PortfolioViewModel model)
        {
            if (model.File != null)
            {
                string upload = Path.Combine(web.WebRootPath, @"assets\img\portfolio");
                string fullPath = Path.Combine(upload, model.File.FileName);
                FileStream fileStream = new FileStream(fullPath, FileMode.Create);
                model.File.CopyTo(fileStream);
            }
        }
    }
}
