namespace UdemyCloneApi.Model
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }

        // İlişkiler
        public int LessonId { get; set; }
        public Lesson lesson { get; set; }
    }
}
