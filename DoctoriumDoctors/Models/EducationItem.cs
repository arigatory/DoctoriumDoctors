using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctoriumDoctors.Models
{
    public class EducationItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int DurationInMonthes { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
