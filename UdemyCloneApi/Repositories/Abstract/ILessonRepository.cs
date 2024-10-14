using UdemyCloneApi.Model;

namespace UdemyCloneApi.Repositories.Abstract
{
    public interface ILessonRepository
    {
        Task<List<Lesson>> GetAllAsync();
        Task<Lesson> GetByIdAsync(int id);
        Task AddAsync(Lesson lesson);
        Task UpdateAsync(Lesson lesson);
        Task DeleteAsync(Lesson lesson);
    }
}
