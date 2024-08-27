using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Contracts
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Your Password {2} to {1} Char", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
