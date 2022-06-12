using System.Collections.Generic;

namespace Rental_Property_Management_Tool.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<RentalProperty> RentalProperties { get; set; }
    }
}
