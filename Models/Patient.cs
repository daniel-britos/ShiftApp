using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShiftApp.Models
{
    public class Patient : Person
    {
        public int PersonalDocument{ get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DefaultValue("0000000")]
        public string CellPhone { get; set; }

        public List<Professional> Professionals { get; set; }
    }
}
