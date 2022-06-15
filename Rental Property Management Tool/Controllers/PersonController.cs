using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rental_Property_Management_Tool.Dtos.Person;
using Rental_Property_Management_Tool.ServiceResponse;
using Rental_Property_Management_Tool.Services.PersonService;

namespace Rental_Property_Management_Tool.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PersonController:ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetPersonDto>>>> Get()
        {
            return Ok(await _personService.GetAllPersons());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetPersonDto>>> GetSingle(int id)
        {
            return Ok(await _personService.GetPersonById(id));
        }



        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetPersonDto>>>> AddPerson(AddPersonDto newPerson)
        {
            return Ok(await _personService.AddPerson(newPerson));
        }



        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetPersonDto>>> UpdatePerson(UpdatePersonDto updatedPerson)
        {
            var response = await _personService.UpdatePerson(updatedPerson);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }



        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetPersonDto>>> Delete(int id)
        {
            var response = await _personService.DeletePerson(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
