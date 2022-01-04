using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Web;

namespace WebApplicationAssignment.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
 
        [Required]
        public string Gender { get; set; }

        [RegularExpression(".+@.+\\..+", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [RegularExpression("((\\+\\d{1,2}\\s?)?1?\\-?\\.?\\s?\\(?\\d{3}\\)?[\\s.-]?)?\\d{3}[\\s.-]?\\d{4}", ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }


    }
}
