using UdemyCloneApi.DTO;

namespace UdemyCloneApi.Services.Abstract
{
    public interface IUserService
    {
        Task<string> LoginAsync(UserDto userDto);
        Task RegisterAsync(UserDto userDto);
    }
}
