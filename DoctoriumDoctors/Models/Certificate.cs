using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctoriumDoctors.Models
{
    public class Certificate
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOfReceipt { get; set; }
    }
}
