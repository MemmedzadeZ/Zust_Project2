using System.ComponentModel.DataAnnotations;

namespace Zust_Project_MVC.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
        [DataType(DataType.EmailAddress)]

        public string? Email { get; set; }

        //   public string? City { get; set; }

        [Required]
        public bool Privacy { get; set; }

        
        public IFormFile? File { get; set; }
        public string? ImageURL { get; set; } = "~/Models/wwwroot/assets/images/user/user.png";

    }
}
