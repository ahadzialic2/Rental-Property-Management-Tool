using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rental_Property_Management_Tool.Data;
using Rental_Property_Management_Tool.Dtos.RentalProperty;
using Rental_Property_Management_Tool.Models;

namespace Rental_Property_Management_Tool.Services.RentalPropertyService
{
    public class RentalPropertyService : IRentalPropertyService {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RentalPropertyService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _context = context;
        }
        //private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        public Task<ServiceResponse<List<GetRentalPropertyDto>>> GetAllRentalProperties()
        {
           
            throw new System.NotImplementedException();
           
        }

        public Task<ServiceResponse<GetRentalPropertyDto>> GetRentalPropertyById(int id)
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
