using System;

namespace Rental_Property_Management_Tool.Dtos.OverheadCost
{
    public class AddOverheadCostDto
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public DateTime? Date { get; set; }
    }
}
