using HouseManagement.Domain.Entity;
using HouseManagement.Domain.Interfaces;
using HouseManagement.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace HouseManagement.Infra.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDBContext _application;

        public PersonRepository(ApplicationDBContext application)
        {
            _application = application;
        }
        public async Task<Person> Get(int id)
        {
            Person? person = await _application.People.SingleOrDefaultAsync(x => x.Id == id);
            if(person == null)
            {
                throw new ApplicationException("Pessoa não encontrada.");
            }
            return person;
        }
    }
}
