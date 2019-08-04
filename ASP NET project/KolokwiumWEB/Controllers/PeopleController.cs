using KolokwiumWEB.Models;
using KolokwiumWEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KolokwiumWEB.Controllers
{
    public class PeopleController : Controller
    {
        PeopleDbContext _context;
        // GET: People
        public PeopleController()
        {
            _context = new PeopleDbContext();
        }
        public ActionResult Index()
        {
            var vm = new PeopleIndexViewModel()
            {
                People = _context.People.OrderBy(a => a.Name).ToList(),
                Rabats = _context.Rabats.OrderBy(t => t.Name).ToList(),
                Person = new Person(),

            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(PeopleIndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(model.Person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            model.People = _context.People.OrderBy(a => a.Name).ToList();
            model.Rabats = _context.Rabats.OrderBy(t => t.Name).ToList();
            return View(model);
        }

    }
}