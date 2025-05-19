using ShoppingAPI.DAL.Entities;

namespace ShoppingAPI.Domain.Interfaces
{
    public interface ICountryService
    {

        
       Task<IEnumerable<Country>> GetCountryAsync(); // firmas de los metodos lista de objetos 

        Task<Country> CreateCountryAsync(Country country) ; // firma de los metodos crear
        

        Task <Country> GetCountryByIdAsync(Guid Id); // firma de los metodos obtener por id
       
        Task <Country> EditCountryAsync(Country country);   
        
        Task <Country> DeleteCountryAsync(Guid Id); // firma de los metodos eliminar
    }


}
