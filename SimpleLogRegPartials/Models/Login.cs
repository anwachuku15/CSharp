using System;
using System.ComponentModel.DataAnnotations;


namespace SimpleLogRegPartials.Models
{
    public class Login
    {
       [Required]
       [EmailAddress]
       [Display(Name="Email")]
       public string Email {get;set;}

       [Required(ErrorMessage="Password is required")]
       [MinLength(8, ErrorMessage="Must be at least 8 characters")]
       [DataType(DataType.Password)]
       [Display(Name="Password")]
       public string Password {get;set;}
    }
}