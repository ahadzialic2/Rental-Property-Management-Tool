using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Rental_Property_Management_Tool.Data;
using Rental_Property_Management_Tool.Dtos.RentalProperty;
using Rental_Property_Management_Tool.Models;

namespace Rental_Property_Management_Tool.Services.RentalPropertyService
{
    public class RentalPropertyService : IRentalPropertyService {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public RentalPropertyService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public Task<ServiceResponse<List<GetRentalPropertyDto>>> GetAllRentalProperties()
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<GetRentalPropertyDto>> GetRentalPropertiesById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<List<GetRentalPropertyDto>>> AddRentalProperty(AddRentalPropertyDto newRentalProperty)
        {
            throw new System.NotImplementedException();

        }
        public Task<ServiceResponse<GetRentalPropertyDto>> UpdateRentalProperty(UpdateRentalPropertyDto updatedRentalProperty)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<List<GetRentalPropertyDto>>> DeleteRentalProperty(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
