using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftApp.Models
{
    public class Schedule : Person
    {
        public string Speciality { get; set; }
        public DateTime Date { get; set; }
        public string Hour { get; set; }
    }
}
