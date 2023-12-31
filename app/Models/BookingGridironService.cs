﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class BookingGridironService
    {
        public int Id { get; set; }
        public int number { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
