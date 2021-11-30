using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShiftApp.Data;
using ShiftApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace ShiftApp.Controllers
{

    [Authorize(Roles = "SuperAdmin")]
    public class SpecialtiesController : Controller
    {
        private ApplicationDbContext _context;

        public SpecialtiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_context.Specialties.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(string name)
        {
            Specialty oSpeciality = new Specialty();
            oSpeciality.Area = name;

            _context.Specialties.Add(oSpeciality);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Specialty edit = Find(id);
            if (edit == null)
            {
                return RedirectToAction("Index");
            }
            return View(edit);
        }

        public IActionResult Update(int id, string name)
        {
            Specialty edit = Find(id);
            if (edit != null)
            {
                 edit.Area = name;
                _context.Specialties.Update(edit);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        private Specialty Find(int id)
        {
            Specialty find = _context.Specialties.Find(id);

            return find;
        }
    }
}
