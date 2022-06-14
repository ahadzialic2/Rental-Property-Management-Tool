using System.Collections.Generic;

namespace Rental_Property_Management_Tool.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public bool LegalEntity { get; set; }
        public List<RentalProperty> RentedProperties { get; set; }
        public bool IsDeleted { get; set; }
    }
}
