using Microsoft.EntityFrameworkCore;
using UdemyCloneApi.Context;
using UdemyCloneApi.Model;
using UdemyCloneApi.Repositories.Abstract;

namespace UdemyCloneApi.Repositories.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.userName == username);
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
