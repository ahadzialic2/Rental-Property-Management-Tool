using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rental_Property_Management_Tool.Dtos.RentalProperty;
using Rental_Property_Management_Tool.Models;
using Rental_Property_Management_Tool.Services;

namespace Rental_Property_Management_Tool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentalPropertyController : ControllerBase
    {
        private readonly IRentalPropertyService _rentalPropertyService;
        public RentalPropertyController(IRentalPropertyService rentalPropertyService)
        {
            _rentalPropertyService = rentalPropertyService; 
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetRentalPropertyDto>>>> Get()
        {
            return Ok(await _rentalPropertyService.GetAllRentalProperties());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetRentalPropertyDto>>> GetSingle(int id)
        {
            return Ok(await _rentalPropertyService.GetRentalPropertyById(id));
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetRentalPropertyDto>>>> AddRentalProperty(AddRentalPropertyDto newRentalProperty)
        {
            return Ok(await _rentalPropertyService.AddRentalProperty(newRentalProperty));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetRentalPropertyDto>>> UpdateRentalProperty(UpdateRentalPropertyDto updatedRentalProperty)
        {
            var response = await _rentalPropertyService.UpdateRentalProperty(updatedRentalProperty);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetRentalPropertyDto>>> Delete(int id)
        {
            var response = await _rentalPropertyService.DeleteRentalProperty(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
