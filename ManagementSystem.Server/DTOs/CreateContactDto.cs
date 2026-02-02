using ManagementSystem.Server.Models;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Server.DTOs
{
    public class CreateContactDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$",
    ErrorMessage = "Only valid Gmail addresses are allowed")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        public string Message { get; set; }
    }
}
