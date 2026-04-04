using System.ComponentModel.DataAnnotations;

namespace SbuNolda.Models
{
    public class ContactMessage
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a message")]
        public string Message { get; set; } = string.Empty;
    }
}
