using UdemyCloneApi.Model;

namespace UdemyCloneApi.Repositories.Abstract
{
    public interface IVideoRepository
    {
        Task<List<Video>> GetByLessonIdAsync(int lessonId);
        Task AddAsync(Video video);
        Task UpdateAsync(Video video);
        Task DeleteAsync(Video video);
    }
}
