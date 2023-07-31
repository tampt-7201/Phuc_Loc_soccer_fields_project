using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class UserBookingGridiron
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public int GridironId { get; set; }
        public Gridiron Gridiron { get; set; }
        public ICollection<BookingGridironHour> bookingGridironHours { get; set; }
    }
}
