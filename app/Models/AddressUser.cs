namespace app.Models
{
    public class AddressUser
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
