using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Creational_Patterns.Singleton_Pattern.Models
{
   public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string JobDescription { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
    }
}
