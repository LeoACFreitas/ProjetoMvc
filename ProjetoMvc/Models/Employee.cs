using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMvc.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeId { get; set; }

        [RegularExpression(@"(\D+)", ErrorMessage = "The Name must have just alphabetic charaters.")]
        [Required(ErrorMessage ="Enter First Name")]
        public string FirstName { get; set; }

        [StringLength(10, ErrorMessage ="Last Name length should not be greater than 5")]
        public string LastName { get; set; }
        public int Salary { get; set; }

    }
}