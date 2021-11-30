using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShiftApp.Data;
using ShiftApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ShiftApp.Controllers
{
    [Authorize(Roles = "SuperAdmin, Professional")]
    public class PatientsController : Controller
    {
        private ApplicationDbContext _context;

        public PatientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Save(string name, string lastname, int personaldocument, DateTime dateofbirth, int gender, string email, string callphone)
        {
            Patient oPatient = new Patient()
            {
                Name = name,
                LastName = lastname,
                PersonalDocument = personaldocument,
                DateOfBirth = dateofbirth,
                Gender = gender,
                Email = email,
                CellPhone = callphone
            };

            try
            {
                _context.Patients.Add(oPatient);
                _context.SaveChanges();

                ViewBag.Error = "";

                return RedirectToAction("Index");
            }
            catch (Exception error)
            {
                ViewBag.Error = error.Message;
                return View("Create", oPatient);
            }
        }
    }
}
