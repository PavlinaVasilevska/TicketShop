using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TicketShop.Domain.Identity
{
    public class UserRegistrationDto
    {
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Required(ErrorMessage = "Email address is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required.")]
        [Compare("Password", ErrorMessage = "The password and confirm password don't match. Please try again.")]
        public string ConfirmPassword { get; set; }
    }
}
