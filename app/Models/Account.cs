namespace app.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
