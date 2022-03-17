using DoctoriumDoctors.Models;
using DoctoriumDoctors.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DoctoriumDoctors.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly ISpecialityRepository _specialityRepository;

        public DoctorController(IDoctorRepository doctorRepository, ISpecialityRepository specialityRepository)
        {
            _doctorRepository = doctorRepository;
            _specialityRepository = specialityRepository;
        }

        public ViewResult List()
        {
            DoctorsListViewModel doctorsListViewModel = new DoctorsListViewModel();
            var doctors = _doctorRepository.AllDoctors;
            var specialities = _specialityRepository.AllSpecialties;
            foreach (var doctor in doctors)
            {
                doctor.Speciality = specialities.FirstOrDefault( s => s.Id == doctor.SpecialityId);
            }
            doctorsListViewModel.Doctors = doctors.OrderBy(d => Guid.NewGuid()).ToList();
            doctorsListViewModel.CurrentSpeciality = "Все доктора";
            return View(doctorsListViewModel);
        }

    }
}
