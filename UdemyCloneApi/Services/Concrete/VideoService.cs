using UdemyCloneApi.Model;
using UdemyCloneApi.Repositories.Abstract;
using UdemyCloneApi.Services.Abstract;

namespace UdemyCloneApi.Services.Concrete
{
    public class VideoService : IVideoService
    {
        private readonly IVideoRepository _videoRepository;

        public VideoService(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        public async Task<List<Video>> GetByLessonIdAsync(int lessonId)
        {
            return await _videoRepository.GetByLessonIdAsync(lessonId);
        }

        public async Task AddAsync(Video video)
        {
            await _videoRepository.AddAsync(video);
        }

        public async Task UpdateAsync(Video video)
        {
            await _videoRepository.UpdateAsync(video);
        }

        public async Task DeleteAsync(int id)
        {
            var video = await _videoRepository.GetByLessonIdAsync(id);
            if (video != null)
            {
                await _videoRepository.DeleteAsync(video.First());
            }
        }
    }
}
