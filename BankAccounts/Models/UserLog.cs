using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    public class UserLog
    {
        [Required]
        [EmailAddress]
        public string LogEmail {get;set;}

        [Required(ErrorMessage="Wrong password")]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [DataType(DataType.Password)]
        public string LogPassword {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}