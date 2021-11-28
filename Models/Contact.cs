using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShiftApp.Models
{
    public class Contact : Base
    {

        [Display(Name = "Name")]
        [StringLength(12)]
        [Required(ErrorMessage = "Name required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Last name required.")]
        [StringLength(12)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "e-mail required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Write something...")]
        [Display(Name = "Comment")]
        [StringLength(200)]
        public string Note { get; set; }
    }
}
