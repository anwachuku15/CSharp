using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
       [Key]
       public int DishID {get;set;}

       [Required(ErrorMessage="Name is required")]
       [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
       [Display(Name="Name of Dish")]
       public string Name {get;set;}

       [Required(ErrorMessage="Chef is required")]
       [MinLength(2, ErrorMessage="Chef's name must be at least 2 characters")]
       [Display(Name="Chef's Name")]
       public string Chef {get;set;}

       [Required(ErrorMessage="Name is required")]
       [Range(1, 6, ErrorMessage="Tastiness must be between 1 and 5")]
       [Display(Name="Tastiness")]
       public int Tastiness {get;set;}

       [Required(ErrorMessage="Calories are required")]
       [Range(1, 9999, ErrorMessage="Calories must be greater than 0")]
       [Display(Name="Calories")]
       public int Calories {get;set;}

       [Required(ErrorMessage="Description required")]
       [Display(Name = "Description")]
       public string Description {get;set;}
       public DateTime CreatedAt {get;set;} = DateTime.Now;
       public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}