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
    public class ContactsController : Controller
    {
        private ApplicationDbContext _context;
        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }



        [HttpPost]
        public IActionResult Save(string name, string lastname, string email, string note)
        {

            Contact NewNote = new Contact()
            {
                Name = name,
                LastName = lastname,
                Email = email,
                Note = note
            };


            _context.Posts.Add(NewNote);
            _context.SaveChanges();
            if (NewNote.Note != null)
            {
                ViewBag.msg = "Message sent.. Within 48hs you will be attended by our staff.";
            }


            return View("Comment");

        }
        public IActionResult Comment()
        {
            return View();
        }



    }
}
