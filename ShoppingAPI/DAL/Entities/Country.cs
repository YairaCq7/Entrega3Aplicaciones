using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI.DAL.Entities
{
    public class Country:Auditbase
    {
        [Display(Name = "Id")]//nombre para mostrar
        [MaxLength(50, ErrorMessage ="El campo {0} debe tener máximo {1} caracteres. ")]//maximo 50 caracteres
        [Required (ErrorMessage ="Es  campo {0} es obligatorio ")]//obligatorio
        public  string?  Name { get; set; }
    }
}
