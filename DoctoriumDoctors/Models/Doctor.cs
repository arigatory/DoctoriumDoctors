using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctoriumDoctors.Models
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
        public ICollection<EducationItem> EducationItems { get; set; }
        public Specialty Speciality { get; set; }
        public Guid SpecialityId { get; set; }
        public DateTime? StartOfWorkExperience { get; set; }
        public bool Accepted { get; set; }
    }
}
