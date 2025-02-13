using HouseManagement.Domain.Entity;
using HouseManagement.Domain.Interfaces;
using HouseManagement.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace HouseManagement.Infra.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _application;

        public PersonRepository(ApplicationDbContext application)
        {
            _application = application;
        }
        public async Task<Person> Get(int id)
        {
            Person? person = await _application.People.Include(x=>x.Transactions).SingleOrDefaultAsync(x => x.Id == id);
            if(person == null)
            {
                throw new ApplicationException("Pessoa não encontrada.");
            }
            return person;
        }
        public async Task<List<Person>> GetAll()
        {
            List<Person>? people = await _application.People.Include(x=>x.Transactions).ToListAsync();
            if (people == null)
            {
                throw new ApplicationException("Sem pessoas");
            }
            return people;
        }
    }
}
