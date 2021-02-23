using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly IUnitOfWork<Contact> contact;

        public ContactController(IUnitOfWork<Contact> contact)
        {
            this.contact = contact;
        }
        public IActionResult Index()
        {
            IEnumerable<Contact> contacts = contact.Entity.AllData().ToList();
            return View(contacts);
        }
        [HttpGet]
        public IActionResult Index(string searchContact, string sortOrder,string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["ClientName"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["EmailAddress"] = sortOrder == "Email" ? "email_desc" : "email_asc";
            ViewData["Message"] = sortOrder == "Message" ? "message_asc" : "message_desc";
            if (searchContact != null)
                pageNumber = 1;
            else
                searchContact = currentFilter;
            ViewData["CurrentFilter"] = searchContact;
            IEnumerable<Contact> contactsQuery = from c in contact.Entity.AllData()
                                                 select c;
            if(!string.IsNullOrEmpty(searchContact))
            {
                contactsQuery = contactsQuery.Where(c => c.ClientName.Contains(searchContact) || c.Email.Contains(searchContact));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.ClientName);
                    break;
                case "email_desc":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.Email);
                    break;
                case "email_asc":
                    contactsQuery = contactsQuery.OrderBy(c => c.Email);
                    break;
                case "message_asc":
                    contactsQuery = contactsQuery.OrderBy(c => c.Message);
                    break;
                case "message_desc":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.Message);
                    break;
                default:
                    contactsQuery = contactsQuery.OrderBy(c => c.ClientName);
                    break;
            }
            int pageSize = 2;
            return View(PaginatedList<Contact>.Create(contactsQuery,pageNumber??1,pageSize));
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();
           Contact c = contact.Entity.GetById(id ?? 0);
            if (c == null)
                return NotFound();
            return View(c);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact c)
        {
            if(ModelState.IsValid)
            {
                contact.Entity.Create(c);
                contact.Save();
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
        public IActionResult Edit(Contact c)
        {
            if(ModelState.IsValid)
            {
                contact.Entity.Edit(c);
                contact.Save();
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
            Contact c = contact.Entity.GetById(id??0);
            if(c != null)
            {
                contact.Entity.Delete(id ?? 0);
                contact.Save();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}
