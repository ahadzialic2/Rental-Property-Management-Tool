using System.Collections.Generic;

namespace Rental_Property_Management_Tool.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public bool LegalEntity { get; set; }
        public List<RentalProperty> RentedProperties { get; set; }
    }
}
