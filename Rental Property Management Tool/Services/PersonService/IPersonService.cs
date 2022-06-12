using System.Collections.Generic;
using System.Threading.Tasks;
using Rental_Property_Management_Tool.Dtos.OverheadCost;
using Rental_Property_Management_Tool.Dtos.Person;
using Rental_Property_Management_Tool.ServiceResponse;

namespace Rental_Property_Management_Tool.Services.PersonService
{
    public interface IPersonService
    {
        Task<ServiceResponse<List<GetPersonDto>>> GetAllPersons();
        Task<ServiceResponse<GetPersonDto>> GetPersonById(int id);
        Task<ServiceResponse<List<GetPersonDto>>> AddPerson(AddPersonDto newPerson);
        Task<ServiceResponse<GetPersonDto>> UpdatePerson(UpdatePersonDto updatedPerson);
        Task<ServiceResponse<List<GetPersonDto>>> DeletePerson(int id);
    }
}
