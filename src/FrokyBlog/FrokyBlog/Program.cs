using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FrokyBlog.Data;
using System.Configuration;

namespace FrokyBlog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddDbContext<FrokyBlogContext>(options =>
            //options.UseSqlServer(builder.Configuration.GetConnectionString("FrokyBlogContext") ?? throw new InvalidOperationException("Connection string 'FrokyBlogContext' not found.")));

            builder.Services.AddDbContext<FrokyBlogContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}