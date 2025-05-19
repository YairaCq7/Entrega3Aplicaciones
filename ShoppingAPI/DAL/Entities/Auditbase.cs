using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI.DAL.Entities
{
    public class Auditbase
    {
        [Key]//pk
        [Required]//obligatorio
        public Guid Id { get; set; } //primary keys de todas las clases
       
        public DateTime? CreatedDate { get; set; } // para guardar todo registro nuevo con su fecha 
        public DateTime? ModifiedDate { get; set; }// guardar todos los registros que se modifican con su fecha 

    }
}
