using System;
using System.Collections.Generic;

namespace Rental_Property_Management_Tool.Models
{
    public class RentalProperty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SquaresMeters { get; set; }
        public string Address { get; set; }
        public bool Rented { get; set; }
        public TypeOfRentalProperty Type { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime RentalEnd { get; set; }
        public List<OverheadCosts> Costs { get; set; }
        public User User { get; set; }
        public Person Persons { get; set; }
    }
}
