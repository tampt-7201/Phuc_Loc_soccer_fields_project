using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public ICollection<BookingGridironService> BookingGridironServices { get; set; }
    }
}
