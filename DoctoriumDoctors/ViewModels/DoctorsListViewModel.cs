using DoctoriumDoctors.Models;
using System.Collections.Generic;

namespace DoctoriumDoctors.ViewModels
{
    public class DoctorsListViewModel
    {
        public IEnumerable<Doctor> Doctors { get; set; }
        public string CurrentSpeciality { get; set; }
    }
}
