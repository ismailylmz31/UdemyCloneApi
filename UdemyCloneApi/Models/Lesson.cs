using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace UdemyCloneApi.Model
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // İlişkiler
        public List<Video> Videos { get; set; }
    }
}
