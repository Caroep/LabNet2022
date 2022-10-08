using System.ComponentModel.DataAnnotations;

namespace Practica.EF.MVC.Models
{
    public class CategoriesView
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50), MaxLength(100)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [StringLength(150),MaxLength(250)]
        [Display (Description ="Descripcion")]
        public string Description { get; set; }
    }
}