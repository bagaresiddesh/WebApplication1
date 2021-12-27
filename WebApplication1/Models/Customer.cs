using System.ComponentModel.DataAnnotations;

namespace WebApplicationAssignment.Models
{
    public enum Gender
    {
        male = 1,
        female = 2,
        other = 3
    }
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }


        [Required]
        public Gender Gender { get; set; }

        [RegularExpression(".+@.+\\..+", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }   

        [RegularExpression("((\\+\\d{1,2}\\s?)?1?\\-?\\.?\\s?\\(?\\d{3}\\)?[\\s.-]?)?\\d{3}[\\s.-]?\\d{4}", ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
    }
}
