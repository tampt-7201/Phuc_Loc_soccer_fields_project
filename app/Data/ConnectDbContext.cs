using Microsoft.EntityFrameworkCore;

namespace app.Data
{
    public class ConnectDbContext : DbContext
    {
        public ConnectDbContext(DbContextOptions<ConnectDbContext> options) : base(options)
        {
        }
    }
}
