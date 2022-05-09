using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Labb1.Net21EntityFrameworkKimWiklund.Models
{
    public class Leaves
    {
        [Key]
        public int LeaveId { get; set; }
        [Required]
        public string Reason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("Employees")]
        public int FEmployeeId { get; set; }
        public Employees Employees { get; set; }

        public DateTime RegistrationTime { get; set; }
    }
}
