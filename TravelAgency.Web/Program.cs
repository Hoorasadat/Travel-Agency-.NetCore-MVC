

// Developer: Hoora


using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelAgency.BLL.Interfaces;
using TravelAgency.BLL.Repositories;
using TravelAgency.Data.Data;

namespace TravelAgency.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            // Add DB settings
            builder.Services.AddDbContextPool<TravelExpertsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TravelExpertsConnection")));


            builder.Services.AddScoped<IBookingRepository, SQLBookingRepository>();
            builder.Services.AddScoped<ICustomerRepository, SQLCustomerRepository>();
            builder.Services.AddScoped<IPackageRepository, SQLPackageRepository>();
            builder.Services.AddScoped<IAgentDetsRepository, SQLAgentDetsRepository>();


            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<TravelExpertsContext>();


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

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}