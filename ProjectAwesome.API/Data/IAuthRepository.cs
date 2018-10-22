using System.Threading.Tasks;
using ProjectAwesome.API.Models;

namespace ProjectAwesome.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);

         Task<User> Login(string username, string password);

         Task<bool> UrerExists(string username);
    }
}