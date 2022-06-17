
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Rental_Property_Management_Tool.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypesOfRentalProperty
    {
        House,
        Garage,
        Apartment
    }
}
