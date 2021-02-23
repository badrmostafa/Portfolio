using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;
using MyPortfolio.IUnitOfWork;
using MyPortfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> owner;
        private readonly IUnitOfWork<Address> address;
        private readonly IUnitOfWork<Portfolio> portfolio;
        private readonly IUnitOfWork<About> about;
        private readonly IUnitOfWork<Contact> contactus;

        public HomeController(IUnitOfWork<Owner> owner, IUnitOfWork<Address> address, IUnitOfWork<Portfolio> portfolio,
            IUnitOfWork<About> about, IUnitOfWork<Contact> contactus)
        {
            this.owner = owner;
            this.address = address;
            this.portfolio = portfolio;
            this.about = about;
            this.contactus = contactus;
        }
        //[Authorize]
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Owner = owner.Entity.AllData().First(),
                Address = address.Entity.AllData().First(),
                Portfolio = portfolio.Entity.AllData().ToList(),
                About = about.Entity.AllData().First()
            };
            return View(homeViewModel);
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            contactus.Entity.Create(contact);
            contactus.Save();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
