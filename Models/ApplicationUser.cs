using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int PersonalDocument { get; set; }
        public byte[] Photo { get; set; }

    }
}
