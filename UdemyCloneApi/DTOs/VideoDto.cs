using System.ComponentModel.DataAnnotations;

namespace UdemyCloneApi.DTO
{
    public class VideoDto
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Video URL is required")]
        public string VideoUrl { get; set; }

        [Required(ErrorMessage = "Lesson ID is required")]
        public int LessonId { get; set; }
    }
}
