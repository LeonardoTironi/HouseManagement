using HouseManagement.Application.DTOs;
using HouseManagement.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HouseManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpPost]
        public async Task<ActionResult> Add(PersonAddDTO personAddDTO)
        {
            await _personService.Add(personAddDTO);
            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            List<PersonResponseDTO> people = await _personService.GetAll();
            return Ok(people);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _personService.Delete(id);
            return NoContent();
        }
    }
}