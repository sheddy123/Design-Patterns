using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Creational_Patterns.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string JobDescription { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal Bonus { get; set; }
        public Employee_Type EmployeeTypeId { get; set; }
        public decimal HouseAllowance { get; set; }
        public decimal MedicalAllowance { get; set; }
        public string ComputerDetails { get; set; }

    }
    
}
