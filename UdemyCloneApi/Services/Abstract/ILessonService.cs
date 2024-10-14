using UdemyCloneApi.Model;

namespace UdemyCloneApi.Services.Abstract
{
    public interface ILessonService
    {
        Task<List<Lesson>> GetAllAsync();
        Task<Lesson> GetByIdAsync(int id);
        Task AddAsync(Lesson lesson);
        Task UpdateAsync(Lesson lesson);
        Task DeleteAsync(int id);
    }
}
