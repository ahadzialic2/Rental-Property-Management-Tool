using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rental_Property_Management_Tool.Data;
using Rental_Property_Management_Tool.Dtos.OverheadCost;
using Rental_Property_Management_Tool.Entities;
using Rental_Property_Management_Tool.ServiceResponse;

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
        public async Task<ServiceResponse<GetOverheadCostDto>> AddOverheadCost(AddOverheadCostDto newOverheadCost, int propertyId)
        {
            var serviceResponse = new ServiceResponse<GetOverheadCostDto>();
            try
            {
                RentalProperty rentalProperty = await _context.RentalProperties.FirstOrDefaultAsync(rp => rp.Id == propertyId);
                if (rentalProperty != null)
                {
                    OverheadCost overheadCost = _mapper.Map<OverheadCost>(newOverheadCost);
                    overheadCost.RentalPropertyId = propertyId;
                    _context.OverheadCosts.Add(overheadCost);
                    await _context.SaveChangesAsync();
                    serviceResponse.Success = true;
                    serviceResponse.Data = _mapper.Map<GetOverheadCostDto>(overheadCost);

                    return serviceResponse;
                }
                serviceResponse.Success = false;
                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
        }
        public Task<ServiceResponse<List<GetOverheadCostDto>>> DeleteOverheadCost(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetOverheadCostDto>>> GetAllOverheadCosts(int? pageNumber, int? pageSize, string? searchQuery)
        {
            var serviceResponse = new ServiceResponse<List<GetOverheadCostDto>>();
            var dbOverheadCosts = await _context.OverheadCosts.ToListAsync();

            if (searchQuery != null)
                dbOverheadCosts = dbOverheadCosts.Where((c => c.Name.ToLower().Contains(searchQuery.ToLower())
                || c.Amount.ToString().Contains(searchQuery.ToLower()))).ToList();

            var currentPageNumber = pageNumber ?? 0;
            var currentPageSize = pageSize ?? 0;
            serviceResponse.Data = dbOverheadCosts.Skip((currentPageNumber - 1) * currentPageSize).Take(currentPageSize).Select(c => _mapper.Map<GetOverheadCostDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetOverheadCostDto>> GetOverheadCostById(int id)
        {
            var serviceResponse = new ServiceResponse<GetOverheadCostDto>();
            var dbOverheadCosts = await _context.OverheadCosts.FirstOrDefaultAsync(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetOverheadCostDto>(dbOverheadCosts);
            return serviceResponse;
        }

        public Task<ServiceResponse<GetOverheadCostDto>> UpdateOverheadCost(UpdateOverheadCostDto updatedOverheadCost)
        {
            throw new System.NotImplementedException();
        }
    }
}
