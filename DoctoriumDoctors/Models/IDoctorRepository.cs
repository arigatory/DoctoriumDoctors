using System;
using System.Collections.Generic;

namespace DoctoriumDoctors.Models
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> AllDoctors { get; }
        IEnumerable<Doctor> DoctorsOfTheWeek { get; }
        Doctor GetDoctorById(Guid doctorId);
    }
}
