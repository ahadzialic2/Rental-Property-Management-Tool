using Microsoft.AspNetCore.Mvc;
using Rental_Property_Management_Tool.Services;

namespace Rental_Property_Management_Tool.Controllers
{
    public class RentalPropertyController : ControllerBase
    {
        private readonly IRentalPropertyService _rentalPropertyService;
        public RentalPropertyController(IRentalPropertyService rentalPropertyService)
        {
            _rentalPropertyService = rentalPropertyService; 

        }
    }
}
