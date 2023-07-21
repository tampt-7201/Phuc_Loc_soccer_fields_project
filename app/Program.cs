using app.Data;
using Microsoft.EntityFrameworkCore;

namespace app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation().AddNToastNotifyToastr();
            builder.Services.AddDbContext<ConnectDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.UseNToastNotify();

            app.Run();
        }
    }
}