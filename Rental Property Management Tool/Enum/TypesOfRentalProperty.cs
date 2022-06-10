using System.Text.Json.Serialization;

namespace Rental_Property_Management_Tool.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypesOfRentalProperty
    {
        House,
        Garage,
        Apartment
    }
}
