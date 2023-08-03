using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public enum BookingStatus
    {
        Unconfirmed,
        Confirmed,
        Canceled
    }
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }
        public BookingStatus Status { get; set; }
        public string Description { get; set; }
        public string PhoneSecondPersion { get; set; }
        public string NameSecondPersion { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<BookingGridironService> BookingGridironServices { get; set; }
        public ICollection<UserBookingGridiron> UserBookingGridirons { get; set; }
        public ICollection<DiscountCode> DiscountCodes { get; set; }
    }
}
