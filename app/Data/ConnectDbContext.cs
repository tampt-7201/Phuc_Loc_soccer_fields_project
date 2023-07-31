using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Data
{
    public class ConnectDbContext : DbContext
    {
        public ConnectDbContext(DbContextOptions<ConnectDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AddressUser> AddressUsers { get; set; }
        public DbSet<PhoneUser> PhoneUsers { get; set; }
        public DbSet<Gridiron> Gridirons { get; set; }
        public DbSet<ImageGridiron> ImageGridirons { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<BookingGridironService> bookingGridironServices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<TypeGridiron> TypeGridirons { get; set; }
        public DbSet<UserBookingGridiron> UserBookingGridirons { get; set; }
        public DbSet<DiscountCode> DiscountCodes { get; set; }
        public DbSet<Hour> hours { get; set; }
        public DbSet<BookingGridironHour> BookingGridironHours { get; set; }
    }
}
