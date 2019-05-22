using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleLogRegPartials.Models
{
    public class Register
    {
       [Required]
       [MinLength(2)]
       [Display(Name="First Name")]
       public string FirstName {get;set;}

       [Required]
       [MinLength(2)]
       [Display(Name="Last Name")]
       public string LastName {get;set;}

       [Required]
       [EmailAddress]
       [Display(Name="Email")]
       public string Email {get;set;}

       [Required(ErrorMessage="Password is required")]
       [MinLength(8, ErrorMessage="Must be at least 8 characters")]
       [DataType(DataType.Password)]
       [Display(Name="Password")]
       public string Password {get;set;}

       [Required(ErrorMessage="Please re-enter your password")]
       [Compare("Password")]
       [DataType(DataType.Password)]
       [Display(Name="Confirm Password")]
       public string Confirm {get;set;}
    }
}