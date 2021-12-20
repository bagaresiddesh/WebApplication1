using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationAssignment.Models
{
    public enum EGender
    {
        male = 1,
        female = 2,
        other = 3
    }
    public class Customer
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Age")]
        public int Age { get; set; }


        [Required(ErrorMessage = "Please Provide Gender")]
        public EGender Gender { get; set; }
    }
}
