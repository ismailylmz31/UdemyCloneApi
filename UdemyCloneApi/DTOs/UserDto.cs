using System.ComponentModel.DataAnnotations;

namespace UdemyCloneApi.DTO
{
    public class UserDto
    {
        [Required(ErrorMessage = "Username is required")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public string Role { get; set; } = "Student"; // Varsayılan rol
    }
}
