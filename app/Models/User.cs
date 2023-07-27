namespace app.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public DateTime DayofBirth { get; set; }
        public ICollection<AddressUser> Addresses { get; set; }
        public ICollection<PhoneUser> Phones { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public int AcountId { get; set; }
        public Account Account { get; set; }
    }
}
