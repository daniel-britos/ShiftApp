using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShiftApp.Data;
using ShiftApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace ShiftApp.Controllers
{
    [Authorize(Roles = "SuperAdmin, Professional")]
    public class ProfesionalesController : Controller
    {
        private ApplicationDbContext _context;
        public ProfesionalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Professional> list = _context.Professionals.Include("Specialtly").ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            ViewBag.SpecialtiesList = _context.Specialties.ToList();

            return View()
        }

        public IActionResult Save(string name, string lastname, string registration, int specialtlyID)
        {
            Professional oNew = new Professional()
            {
                Name = name,
                LastName = lastname,
                Registration = registration,
                SpecialityID = specialtlyID
            };
            _context.Professionals.Add(oNew);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public List<Professional> GetBySpecialtly(int specialtlyID)
        {
            return _context.Professionals.Where(p => p.SpecialityID == specialtlyID).ToList();
        }
    }
}
