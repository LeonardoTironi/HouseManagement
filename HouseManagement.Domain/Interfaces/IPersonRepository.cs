using HouseManagement.Domain.Entity;

namespace HouseManagement.Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<Person> Get(int id);
    }
}
