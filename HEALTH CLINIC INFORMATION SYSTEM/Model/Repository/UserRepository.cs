using System.Linq;
using System.Threading.Tasks;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Repository;
using Microsoft.EntityFrameworkCore;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Context;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UserModel> GetUserByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Username == username);
        }

        public async Task AddUserAsync(UserModel user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
