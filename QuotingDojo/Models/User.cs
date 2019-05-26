using System;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
    public class User
    {
       [Required(ErrorMessage="Name is required")]
       [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
       [Display(Name="Your Name: ")]
       public string Name {get;set;}

       [Required(ErrorMessage="Quote is required")]
       [MaxLength(280, ErrorMessage="Quote must be less than 280 characters")]
       [Display(Name="Your Quote: ")]
       public string Quote {get;set;}
    }
}