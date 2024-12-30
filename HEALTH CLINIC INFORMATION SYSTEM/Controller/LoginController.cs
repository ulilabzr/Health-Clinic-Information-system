using System.Threading.Tasks;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Repository;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity;


namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Controllers
{
    public class LoginController
    {
        private readonly IUserRepository _userRepository;

        public LoginController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            if (user != null && user.Password == password)
            {
                return true;
            }
            return false;
        }
    }
}
