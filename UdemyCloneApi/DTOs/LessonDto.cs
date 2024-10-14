using System.ComponentModel.DataAnnotations;

namespace UdemyCloneApi.DTO
{
    public class LessonDto
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
