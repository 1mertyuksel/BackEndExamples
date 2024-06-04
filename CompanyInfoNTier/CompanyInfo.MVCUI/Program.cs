using CompanyInfo.BL.Managers.Abstract;
using CompanyInfo.BL.Managers.Concrete;
using CompanyInfo.Entities.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace CompanyInfo.MVCUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IBirimManager, BirimManager>();
            builder.Services.AddScoped<IUrunManager,UrunManager>();
            builder.Services.AddScoped<IKategoriManager,KategoriManager>();

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("default"))
            );
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
