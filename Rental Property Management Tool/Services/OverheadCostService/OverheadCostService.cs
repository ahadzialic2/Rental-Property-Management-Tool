using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Rental_Property_Management_Tool.Data;
using Rental_Property_Management_Tool.Dtos.OverheadCost;
using Rental_Property_Management_Tool.Models;

namespace Rental_Property_Management_Tool.Services.OverheadCostService
{
    public class OverheadCostService : IOverheadCostService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public OverheadCostService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public Task<ServiceResponse<List<GetOverheadCostDto>>> AddOverheadCost(AddOverheadCostDto newOverheadCost)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<List<GetOverheadCostDto>>> DeleteOverheadCost(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<List<GetOverheadCostDto>>> GetAllOverheadCosts()
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<GetOverheadCostDto>> GetOverheadCostById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<GetOverheadCostDto>> UpdateOverheadCost(UpdateOverheadCostDto updatedOverheadCost)
        {
            throw new System.NotImplementedException();
        }
    }
}
