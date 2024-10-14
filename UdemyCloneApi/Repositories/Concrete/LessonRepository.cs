using Microsoft.EntityFrameworkCore;
using UdemyCloneApi.Context;
using UdemyCloneApi.Model;
using UdemyCloneApi.Repositories.Abstract;

namespace UdemyCloneApi.Repositories.Concrete
{
    public class LessonRepository : ILessonRepository
    {
        private readonly AppDbContext _context;

        public LessonRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Lesson>> GetAllAsync()
        {
            return await _context.Lessons.Include(l => l.Videos).ToListAsync();
        }

        public async Task<Lesson> GetByIdAsync(int id)
        {
            return await _context.Lessons.Include(l => l.Videos).FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task AddAsync(Lesson lesson)
        {
            await _context.Lessons.AddAsync(lesson);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Lesson lesson)
        {
            _context.Lessons.Update(lesson);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Lesson lesson)
        {
            _context.Lessons.Remove(lesson);
            await _context.SaveChangesAsync();
        }
    }
}
