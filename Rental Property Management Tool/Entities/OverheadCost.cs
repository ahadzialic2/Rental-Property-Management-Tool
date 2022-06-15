using System;
using System.Collections.Generic;

namespace Rental_Property_Management_Tool.Entities
{
    public class OverheadCost
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public DateTime? Date { get; set; }
        public RentalProperty RentalProperty { get; set; }
        public int RentalPropertyId { get; set; }
    }
}
