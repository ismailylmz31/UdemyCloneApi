using UdemyCloneApi.Model;
using UdemyCloneApi.Repositories.Abstract;
using UdemyCloneApi.Services.Abstract;

namespace UdemyCloneApi.Services.Concrete
{

    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public async Task<List<Lesson>> GetAllAsync()
        {
            return await _lessonRepository.GetAllAsync();
        }

        public async Task<Lesson> GetByIdAsync(int id)
        {
            return await _lessonRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Lesson lesson)
        {
            await _lessonRepository.AddAsync(lesson);
        }

        public async Task UpdateAsync(Lesson lesson)
        {
            await _lessonRepository.UpdateAsync(lesson);
        }

        public async Task DeleteAsync(int id)
        {
            var lesson = await _lessonRepository.GetByIdAsync(id);
            if (lesson != null)
            {
                await _lessonRepository.DeleteAsync(lesson);
            }
        }
    }
}
