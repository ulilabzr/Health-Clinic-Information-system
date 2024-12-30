using System.Threading.Tasks;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity;


namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Repository
{
    public interface IUserRepository
    {
        Task<UserModel> GetUserByUsernameAsync(string username);
        Task AddUserAsync(UserModel user);
    }
}
