using Microsoft.EntityFrameworkCore;
using UdemyCloneApi.Context;
using UdemyCloneApi.Model;
using UdemyCloneApi.Repositories.Abstract;

namespace UdemyCloneApi.Repositories.Concrete
{
    public class VideoRepository : IVideoRepository
    {
        private readonly AppDbContext _context;

        public VideoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Video>> GetByLessonIdAsync(int lessonId)
        {
            return await _context.Videos.Where(v => v.LessonId == lessonId).ToListAsync();
        }

        public async Task AddAsync(Video video)
        {
            await _context.Videos.AddAsync(video);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Video video)
        {
            _context.Videos.Update(video);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Video video)
        {
            _context.Videos.Remove(video);
            await _context.SaveChangesAsync();
        }
    }
}
