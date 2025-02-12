using AutoMapper;
using HouseManagement.Application.DTOs;
using HouseManagement.Application.Interfaces;
using HouseManagement.Domain.Entity;
using HouseManagement.Domain.Interfaces;

namespace HouseManagement.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IGeneralRepository _generalRepository;
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public PersonService(IGeneralRepository generalRepository, IPersonRepository personRepository, IMapper mapper)
        {
            _generalRepository = generalRepository;
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task Add(PersonAddDTO personAddDTO)
        {
            try
            {
                Person person = _mapper.Map<Person>(personAddDTO);
                await _generalRepository.Add(person);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao cadastrar uma pessoa.");
            }
        }
        public Task<PersonResponseDTO> Get(int id)
        {
            throw new NotImplementedException();
        }
        public Task Update(PersonUpdateDTO personUpdateDTO)
        {
            throw new NotImplementedException();
        }


        public async Task Delete(int id)
        {
            try
            {
                Person person = await _personRepository.Get(id);
                await _generalRepository.Delete(person);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao deletar pessoa.");
            }
        }

    }
}
