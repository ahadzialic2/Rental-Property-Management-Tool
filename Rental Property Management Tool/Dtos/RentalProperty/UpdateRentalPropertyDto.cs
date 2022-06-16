using System;
using System.Collections.Generic;
using Rental_Property_Management_Tool.Dtos.OverheadCost;
using Rental_Property_Management_Tool.Dtos.Person;
using Rental_Property_Management_Tool.Enum;

namespace Rental_Property_Management_Tool.Dtos.RentalProperty
{
    public class UpdateRentalPropertyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SquaresMeters { get; set; }
        public string Address { get; set; }
        public bool IsRented { get; set; }
        public TypesOfRentalProperty Type { get; set; }
        public DateTime? RentalStart { get; set; }
        public DateTime? RentalEnd { get; set; }
        public GetPersonDto Person { get; set; }
    }
}
