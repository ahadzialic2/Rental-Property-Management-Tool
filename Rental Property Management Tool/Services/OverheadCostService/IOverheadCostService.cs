using System.Collections.Generic;
using System.Threading.Tasks;
using Rental_Property_Management_Tool.Dtos.OverheadCost;
using Rental_Property_Management_Tool.Dtos.RentalProperty;
using Rental_Property_Management_Tool.ServiceResponse;

namespace Rental_Property_Management_Tool.Services.OverheadCostService
{
    public interface IOverheadCostService
    {
        Task<ServiceResponse<List<GetOverheadCostDto>>> GetAllOverheadCosts(int? pageNumber, int? pageSize, string? searchQuery);
        Task<ServiceResponse<GetOverheadCostDto>> GetOverheadCostById(int id);
        Task<ServiceResponse<GetOverheadCostDto>> AddOverheadCost(AddOverheadCostDto newOverheadCost, int propertyId);
        Task<ServiceResponse<GetOverheadCostDto>> UpdateOverheadCost(UpdateOverheadCostDto updatedOverheadCost);
        Task<ServiceResponse<List<GetOverheadCostDto>>> DeleteOverheadCost(int id);
    }
}
