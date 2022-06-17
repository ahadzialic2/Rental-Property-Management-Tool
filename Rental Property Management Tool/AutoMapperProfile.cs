using AutoMapper;
using Rental_Property_Management_Tool.Dtos.OverheadCost;
using Rental_Property_Management_Tool.Dtos.Person;
using Rental_Property_Management_Tool.Dtos.RentalProperty;
using Rental_Property_Management_Tool.Entities;

namespace Rental_Property_Management_Tool
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RentalProperty, GetRentalPropertyDto>().ReverseMap();
            CreateMap<RentalProperty, GetRentalPropertyAndPersonRentedDto>().ReverseMap();
            CreateMap<AddRentalPropertyDto, RentalProperty>().ReverseMap();
            CreateMap<Person, GetPersonDto>().ReverseMap();
            CreateMap<GetPersonDto, Person>().ReverseMap();
            CreateMap<AddPersonDto,Person>();
            CreateMap<OverheadCost, AddOverheadCostDto> ();
            CreateMap<AddOverheadCostDto, OverheadCost>();
            CreateMap<OverheadCost, GetOverheadCostDto>();
            CreateMap<GetOverheadCostDto, OverheadCost>();

        }
    }
}
