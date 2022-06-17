using System.Collections.Generic;
using System.Threading.Tasks;
using Rental_Property_Management_Tool.Dtos.RentalProperty;
using Rental_Property_Management_Tool.ServiceResponse;

namespace Rental_Property_Management_Tool.Services
{
    public interface IRentalPropertyService
    {
        Task<ServiceResponse<List<GetRentalPropertyDto>>> GetAllRentalProperties(int? pageNumber, int? pageSize, string? sortParametar, string? searchQuery);
        Task<ServiceResponse<GetRentalPropertyDto>> GetRentalPropertyById(int id);
        Task<ServiceResponse<List<GetRentalPropertyDto>>> AddRentalProperty(AddRentalPropertyDto newRentalProperty);
        Task<ServiceResponse<GetRentalPropertyDto>> UpdateRentalProperty(UpdateRentalPropertyDto updatedRentalProperty);
        Task<ServiceResponse<List<GetRentalPropertyDto>>> DeleteRentalProperty(int id);
        Task<ServiceResponse<GetRentalPropertyAndPersonRentedDto>> RentPropertyToPerson(int rentalPropertyId, string personName);

    }
}
