using UdemyCloneApi.Model;

namespace UdemyCloneApi.Services.Abstract
{
    public interface IVideoService
    {
        Task<List<Video>> GetByLessonIdAsync(int lessonId);
        Task AddAsync(Video video);
        Task UpdateAsync(Video video);
        Task DeleteAsync(int id);
    }
}
