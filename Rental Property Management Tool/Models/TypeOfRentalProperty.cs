using System.Text.Json.Serialization;


namespace Rental_Property_Management_Tool.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeOfRentalProperty
    {
        House,
        Garage,
        Apartment
    }
}
