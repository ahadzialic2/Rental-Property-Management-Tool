using Rental_Property_Management_Tool.Enum;
using System;
using System.Collections.Generic;

namespace Rental_Property_Management_Tool.Entities
{
    public class RentalProperty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SquaresMeters { get; set; }
        public string Address { get; set; }
        public bool IsRented { get; set; }
        public TypesOfRentalProperty Type { get; set; }
        public DateTime? RentalStart { get; set; }
        public DateTime? RentalEnd { get; set; }
        public List<OverheadCost> Costs { get; set; }
        public User User { get; set; }
        public Person Person { get; set; }
        public bool IsDeleted { get; set; }
    }
}
