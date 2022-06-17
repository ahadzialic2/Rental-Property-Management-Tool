using System;
using System.Collections.Generic;
using Rental_Property_Management_Tool.Dtos.RentalProperty;

namespace Rental_Property_Management_Tool.Dtos.OverheadCost
{
    public class GetOverheadCostDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public DateTime? Date { get; set; }
        public GetRentalPropertyDto RentalProperty { get; set; }
    }
}
