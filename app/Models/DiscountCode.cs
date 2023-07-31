using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class DiscountCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountPercentage { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsUsed { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
