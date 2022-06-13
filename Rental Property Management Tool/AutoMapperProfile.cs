using AutoMapper;
using Rental_Property_Management_Tool.Dtos.Person;
using Rental_Property_Management_Tool.Dtos.RentalProperty;
using Rental_Property_Management_Tool.Entities;

namespace Rental_Property_Management_Tool
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RentalProperty, GetRentalPropertyDto>();
            CreateMap<RentalProperty, GetRentalPropertyAndPersonRentedDto>();

            CreateMap<AddRentalPropertyDto, RentalProperty>();
            CreateMap<Person, GetPersonDto>();
            CreateMap<GetPersonDto, Person>();

            //CreateMap<Skill, GetSkillDto>();
            //CreateMap<Character, HighscoreDto>();*/
        }
    }
}
