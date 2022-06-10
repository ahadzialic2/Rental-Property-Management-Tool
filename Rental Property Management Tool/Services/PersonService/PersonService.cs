using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Rental_Property_Management_Tool.Data;
using Rental_Property_Management_Tool.Dtos.Person;
using Rental_Property_Management_Tool.Models;

namespace Rental_Property_Management_Tool.Services.PersonService
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public PersonService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public Task<ServiceResponse<List<GetPersonDto>>> AddPerson(AddPersonDto newPerson)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<List<GetPersonDto>>> DeletePerson(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<List<GetPersonDto>>> GetAllPersons()
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<GetPersonDto>> GetPersonById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<GetPersonDto>> UpdatePerson(UpdatePersonDto updatedPerson)
        {
            throw new System.NotImplementedException();
        }
    }
}
