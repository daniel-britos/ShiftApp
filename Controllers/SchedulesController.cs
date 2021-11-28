using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShiftApp.Models;
using ShiftApp.Data;

namespace ShiftApp.Controllers
{
    [Authorize]
    public class SchedulesController : Controller
    {
        private ApplicationDbContext _context;
        public SchedulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Confirmed(string speciality, DateTime date, string hour)
        {
            Schedule NewShift = new Schedule()
            {
                Speciality = speciality,
                Date = date,
                Hour = hour
            };

            _context.Schedules.Add(NewShift);
            _context.SaveChanges();

            return View(NewShift);
        }

        public IActionResult Shifts()
        {

            return View();
        }
    }
}
