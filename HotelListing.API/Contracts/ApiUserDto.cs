﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Contracts
{
    public class ApiUserDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15,ErrorMessage ="Your Password {2} to {1} Char",MinimumLength =6)]
        public string Password { get; set; }
    }
}