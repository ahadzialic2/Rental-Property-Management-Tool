using System.Collections.Generic;
using Rental_Property_Management_Tool.Dtos.RentalProperty;
using Rental_Property_Management_Tool.Models;

namespace Rental_Property_Management_Tool.Dtos.OverheadCost
{
    public class GetOverheadCostDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string CostDetails { get; set; }
        public List<GetRentalPropertyDto> RentalProperties { get; set; }
    }
}
