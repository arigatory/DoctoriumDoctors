using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctoriumDoctors.Models
{
    public class Specialty
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Doctor> Doctors { get; set; }
        public bool Popular { get; set; }
    }
}
