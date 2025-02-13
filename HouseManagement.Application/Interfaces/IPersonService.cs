using HouseManagement.Application.DTOs;

namespace HouseManagement.Application.Interfaces
{
    public interface IPersonService
    {
        Task Add(PersonAddDTO personAddDTO);
        Task<PersonResponseDTO> Get(int id);
        Task<List<PersonResponseDTO>> GetAll();
        Task Delete(int id);
    }
}
