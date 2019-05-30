using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2, ErrorMessage="Name must be greater at least 2 characters")]
        [Display(Name="First Name")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2, ErrorMessage="Name must be greater at least 2 characters")]
        [Display(Name="Last Name")]
        public string LastName {get;set;}

        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string Email {get;set;}

        [Required]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        public string Confirm {get;set;}

        public List<Transaction> Transactions {get;set;}

        

    }
}