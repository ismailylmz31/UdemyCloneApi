namespace UdemyCloneApi.Model
{
    public class User
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        // Yeni eklenen alan
        public string Role { get; set; }
    }
}
