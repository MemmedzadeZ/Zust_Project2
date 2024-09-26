using System.ComponentModel.DataAnnotations;

namespace Zust_Project_MVC.Models
{
    public class RegisterViewModel
    {
        [Required]

        public string? Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }


    }
}
