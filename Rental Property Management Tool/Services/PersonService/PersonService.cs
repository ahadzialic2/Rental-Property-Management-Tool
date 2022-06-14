using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rental_Property_Management_Tool.Data;
using Rental_Property_Management_Tool.Dtos.Person;
using Rental_Property_Management_Tool.Entities;
using Rental_Property_Management_Tool.ServiceResponse;

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
        public async Task<ServiceResponse<List<GetPersonDto>>> AddPerson(AddPersonDto newPerson)
        {
            var serviceResponse = new ServiceResponse<List<GetPersonDto>>();
            Person person = _mapper.Map<Person>(newPerson);
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();
            serviceResponse.Data = await _context.Persons.Select(p => _mapper.Map<GetPersonDto>(p)).ToListAsync();
            return serviceResponse;
        }
        public async Task<ServiceResponse<List<GetPersonDto>>> DeletePerson(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetPersonDto>>();
            try
            {
                Person person = await _context.Persons.FirstOrDefaultAsync(p => p.Id == id);
                person.IsDeleted = true;
                await _context.SaveChangesAsync();
                serviceResponse.Data = _context.Persons.Select(p => _mapper.Map<GetPersonDto>(p)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
        public async Task<ServiceResponse<List<GetPersonDto>>> GetAllPersons()
        {
            var serviceResponse = new ServiceResponse<List<GetPersonDto>>();
            var dbPersons = await _context.Persons.ToListAsync();
            serviceResponse.Data = dbPersons.Select(p => _mapper.Map<GetPersonDto>(p)).ToList();
            return serviceResponse;
        }
        public async Task<ServiceResponse<GetPersonDto>> GetPersonById(int id)
        {
            var serviceResponse = new ServiceResponse<GetPersonDto>();
            var dbPersons = await _context.Persons.FirstOrDefaultAsync(p => p.Id == id);
            serviceResponse.Data = _mapper.Map<GetPersonDto>(dbPersons);
            return serviceResponse;
        }
        public async Task<ServiceResponse<GetPersonDto>> UpdatePerson(UpdatePersonDto updatedPerson)
        {
            var serviceResponse = new ServiceResponse<GetPersonDto>();
            try
            {
                Person person = await _context.Persons.FirstOrDefaultAsync(p => p.Id == updatedPerson.Id);
                person.Name = updatedPerson.Name;
                person.Contact = updatedPerson.Contact;
                person.LegalEntity = updatedPerson.LegalEntity;
                

                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<GetPersonDto>(person);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
