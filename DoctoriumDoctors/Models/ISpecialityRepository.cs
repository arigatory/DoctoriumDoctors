using System.Collections.Generic;

namespace DoctoriumDoctors.Models
{
    public interface ISpecialityRepository
    {
        IEnumerable<Specialty> AllSpecialties { get; }
    }
}
