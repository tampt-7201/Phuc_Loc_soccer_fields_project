using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class Gridiron
    {
        public int Id { get; set; }
        public string FieldName { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public ICollection<ImageGridiron> ImageGridirons { get; set; }
        public ICollection<Booking> bookings { get; set; }
    }
}
