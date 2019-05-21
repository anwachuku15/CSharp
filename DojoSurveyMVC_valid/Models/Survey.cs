using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyMVC.Models
{
    public class User
    {
        [Required(ErrorMessage="Name is required")]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
        [Display(Name = "Your Name:")]
        public string Name {get;set;}

        [Required]
        [Display(Name = "Dojo Location:")]
        public string Location {get;set;}

        [Required]
        [Display(Name = "Favorite Language:")]
        public string Language {get;set;}

        
        [MaxLength(20)]
        [Display(Name = "Comment (optional):")]
        public string Comment {get;set;}
    }

}
