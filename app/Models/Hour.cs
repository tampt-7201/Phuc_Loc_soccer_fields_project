namespace app.Models
{
    public class Hour
    {
        public int Id { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public ICollection<BookingGridironHour> bookingGridironHours { get; set; }
    }
}
