using Rental_Property_Management_Tool.Entities;
using Rental_Property_Management_Tool.ServiceResponse;
using System.Threading.Tasks;

namespace Rental_Property_Management_Tool.Services.AuthRepository
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
