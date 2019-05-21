using System;
using System.ComponentModel.DataAnnotations;


namespace FormSubmission.Models
{
    public class User
    {
       [Required]
       [MinLength(4)]
       [Display(Name = "First Name")]
       public string FirstName {get;set;}

       [Required]
       [MinLength(4)]
       [Display(Name = "Last Name")]
       public string LastName {get;set;}

       [Required]
       [Range(1,120, ErrorMessage="Must be a positive number")]
       public int Age {get;set;}

       [Required]
       [EmailAddress(ErrorMessage="Must be a valid email address")]
       [Display(Name = "Email Address")]
       public string Email {get;set;}

       [Required]
       [DataType(DataType.Password)]
       [MinLength(8)]
       public string Password {get;set;}
    }
}