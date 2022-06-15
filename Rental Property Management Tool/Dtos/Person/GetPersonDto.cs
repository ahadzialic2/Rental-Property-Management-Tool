using System.Collections.Generic;
using Rental_Property_Management_Tool.Dtos.RentalProperty;

namespace Rental_Property_Management_Tool.Dtos.Person
{
    public class GetPersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public bool LegalEntity { get; set; }
        public List<GetRentalPropertyDto> RentedProperties { get; set; }
        public bool IsDeleted { get; set; }
    }
}
