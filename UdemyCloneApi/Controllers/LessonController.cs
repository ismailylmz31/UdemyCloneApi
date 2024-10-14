using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UdemyCloneApi.Context;
using UdemyCloneApi.DTO;
using UdemyCloneApi.Model;
using UdemyCloneApi.Services.Abstract;

namespace UdemyCloneApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var lessons = await _lessonService.GetAllAsync();
            return Ok(lessons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var lesson = await _lessonService.GetByIdAsync(id);
            if (lesson == null) return NotFound();
            return Ok(lesson);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Lesson lesson)
        {
            await _lessonService.AddAsync(lesson);
            return Ok(lesson);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Lesson lesson)
        {
            await _lessonService.UpdateAsync(lesson);
            return Ok(lesson);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _lessonService.DeleteAsync(id);
            return Ok(new { Message = "Deleted successfully" });
        }
    }

}
