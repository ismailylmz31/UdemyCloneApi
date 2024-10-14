using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UdemyCloneApi.Context;
using UdemyCloneApi.DTO;
using UdemyCloneApi.Model;
using UdemyCloneApi.Services.Abstract;

namespace UdemyCloneApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoController : ControllerBase
    {
        private readonly IVideoService _videoService;

        public VideoController(IVideoService videoService)
        {
            _videoService = videoService;
        }

        [HttpGet("lesson/{lessonId}")]
        public async Task<IActionResult> GetByLessonId(int lessonId)
        {
            var videos = await _videoService.GetByLessonIdAsync(lessonId);
            return Ok(videos);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Video video)
        {
            await _videoService.AddAsync(video);
            return Ok(video);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Video video)
        {
            await _videoService.UpdateAsync(video);
            return Ok(video);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _videoService.DeleteAsync(id);
            return Ok(new { Message = "Deleted successfully" });
        }
    }


}
