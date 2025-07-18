using System.ComponentModel.DataAnnotations;

namespace Tech_world_Backend.DTOs.UserProfile
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string? UserEmail { get; set; }

        [Required]
        [MinLength(6 , ErrorMessage = "Password must be at least 6 characters.")]
        public string? UserPassword { get; set; }
    }

    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        public string? UserEmail { get; set; }

        [Required]
        [MinLength(6)]
        public string? UserPassword { get; set; }

        public string? FirstName { get; set; }

        public string? MiddelName { get; set; }

        public string? LastName { get; set; }

    }

    public class UserDto
    {
        public int UserId { get; set; }
        public string? UserEmail { get; set; }
        public string? FirstName { get; set; }
        public string? MiddelName { get; set; }
        public string? LastName { get; set; }
    }
}
