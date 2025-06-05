using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI.DAL.Entities
{
    public class State:Auditbase
    {


        [Display(Name = "Estado/Departamento")] // para identificar el nombre más fácil
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener máximo {1} caracteres.")] // longitud
        [Required(ErrorMessage = "Este campo es obligatorio.")] // campo requerido

        public string? Name { get; set; }

        //Así es como relaciono dos tablas en EF Core:
        [Display(Name = "País")]
        public Country? Country { get; set; }

        //fk
        [Display(Name = "Id País")]
        public Guid CountryId { get; set; }

    }
}
