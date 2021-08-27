using System.Threading.Tasks;
using JWT.DEMO.Models;

namespace JWT.DEMO.Services
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModel model);
        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
        Task<AuthenticationModel> RefreshTokenAsync(string token);
        bool RevokeToken(string token);
        ApplicationUser GetById(string id);




        
    }
}