namespace app.Models
{
    public class BookingGridironService
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
