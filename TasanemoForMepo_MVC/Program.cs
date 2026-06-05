using Azure.Core;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Tass_BLL.AddService;
using Tass_DAL.AddService;
using Tass_DAL.Data;

namespace Tass_PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // ========== Dependancy Injection ==========
            // ========== DbContext ==========
            builder.Services.AddDbContext<TasneemContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // ========== Repositories ==========
            builder.Services.AddBusinessInADL();

            // ========== Services ==========
            builder.Services.AddBusinessInBLL();

            // ========== Languages ==========
            builder.Services.AddLocalization();

            var app = builder.Build();
            var supportedCultures = new[]
             {
                new CultureInfo("en-US"),
                new CultureInfo("ar-EG")
            };

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("ar-EG"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures,
                RequestCultureProviders = new List<IRequestCultureProvider>
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                }
            });
            app.UseRouting();

            app.UseAuthorization();

          

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
