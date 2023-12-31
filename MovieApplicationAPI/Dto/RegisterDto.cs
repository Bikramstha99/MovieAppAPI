﻿using MovieAppDomain;
using System.ComponentModel.DataAnnotations;

namespace MovieAppAPI.Dto
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; } 

        [Required]
        public string Password { get; set; } 
        [Required]
        public string ConfirmPassword { get; set; } 

        [Required]
        public string Email { get; set; } 

        [Required]
        public string FirstName { get; set; } 

        [Required]
        public string LastName { get; set; } 

        //[Required]
        //public Role Role { get; set; }
    }
}
