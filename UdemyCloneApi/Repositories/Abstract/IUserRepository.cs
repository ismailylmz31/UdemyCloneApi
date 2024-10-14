using UdemyCloneApi.Model;

namespace UdemyCloneApi.Repositories.Abstract
{
    public interface IUserRepository
    {
        Task<User> GetByUsernameAsync(string username);
        Task AddAsync(User user);
    }
}
