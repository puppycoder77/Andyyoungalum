﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AndyYoungAlum.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User name is required.")]
        [Display(Name = "User name")]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //public string UserType { get; set; }

        //[Required(ErrorMessage = "Email is required.")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "Wrong Email format")]
        //public string Email { get; set; }
    }
}