namespace app.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Rate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Gridiron Gridiron { get; set; }
    }
}
