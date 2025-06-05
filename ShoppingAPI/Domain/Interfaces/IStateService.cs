using ShoppingAPI.DAL.Entities;

namespace ShoppingAPI.Domain.Interfaces
{
    public interface IStateService
    {
   



        // Firma de los métodos para obtener todos los estados
        Task<IEnumerable<State>> GetStatesAsync();

        // Firma del método para obtener un estado por su ID
        Task<State> GetStateByIdAsync(Guid Id);

        // Firma del método para crear un nuevo estado
        Task<State> CreateStateAsync(State state);

        // Firma del método para editar un estado existente
        Task<State> EditStateAsync(State state);

        // Firma del método para eliminar un estado por su ID
        Task<State> DeleteStateAsync(Guid Id);
    }
}