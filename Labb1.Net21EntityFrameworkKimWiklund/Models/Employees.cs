using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb1.Net21EntityFrameworkKimWiklund.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(25)]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(2)]
        public string LastName { get; set; }

        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }

        public ICollection<Leaves> Leaves { get; set; }

        //public static List<Employees> GetEmployees()
        //{
        //    return new List<Employees>()
        //    {
        //        new Employees{EmployeeId = 1, FirstName = "Amanda", LastName = "Westman", Gender = "F", Age = 22},
        //        new Employees{EmployeeId = 2, FirstName = "Sebastian", LastName = "Skalare", Gender = "M", Age = 28},
        //        new Employees{EmployeeId = 3, FirstName = "Kim", LastName = "Wiklund", Gender = "M", Age = 30},
        //        new Employees{EmployeeId = 4, FirstName = "Pelle", LastName = "Westman", Gender = "M", Age = 49},
        //        new Employees{EmployeeId = 5, FirstName = "Sara", LastName = "Bodin", Gender = "F", Age = 27},
        //        new Employees{EmployeeId = 6, FirstName = "Helene", LastName = "Andersson", Gender = "F", Age = 42},
        //        new Employees{EmployeeId = 7, FirstName = "Linnea", LastName = "Häggkvist", Gender = "F", Age = 32},
        //    };
        //}


    }
}
