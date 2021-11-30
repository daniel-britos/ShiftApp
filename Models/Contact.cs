using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShiftApp.Models
{
    public class Contact : Person
    {

        [Required(ErrorMessage = "e-mail required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Write something...")]
        [Display(Name = "Comment")]
        [StringLength(200)]
        public string Note { get; set; }
    }
}
