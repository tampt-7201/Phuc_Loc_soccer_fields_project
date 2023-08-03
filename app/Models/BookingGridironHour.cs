namespace app.Models
{
    public class BookingGridironHour
    {
        public int Id { get; set; }
        public int HourId { get; set; }
        public Hour Hour { get; set; }
        public int UserBookingGridironId { get; set; }
        public UserBookingGridiron UserBookingGridiron { get; set; }
    }
}
