using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftApp.Models
{
    public class Specialty : Base
    {
        [Required]
        public string Area { get; set; }

        public bool Availability { get; set; }
    }
}
