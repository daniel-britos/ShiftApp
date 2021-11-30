using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftApp.Models
{
    public class Professional : Person
    {
        public string Registration { get; set; }

        [Required]
        [Display(Name = "Speciality")]
        public int SpecialityID { get; set; }

        [ForeignKey("EspecialidadID")]
        public Specialty Specialities { get; set; }

        public List<Patient> Patients { get; set; }
    }
}
