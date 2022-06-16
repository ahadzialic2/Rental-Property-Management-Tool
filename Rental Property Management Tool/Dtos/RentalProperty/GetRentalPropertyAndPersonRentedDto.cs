using System;
using Rental_Property_Management_Tool.Dtos.Person;
using Rental_Property_Management_Tool.Enum;

namespace Rental_Property_Management_Tool.Dtos.RentalProperty
{
    public class GetRentalPropertyAndPersonRentedDto
    {
        public string Name { get; set; }
        public double SquaresMeters { get; set; }
        public string Address { get; set; }
        public bool isRented { get; set; }
        public TypesOfRentalProperty Type { get; set; }
    }
}
