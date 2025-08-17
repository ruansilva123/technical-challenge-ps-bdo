
using CorporateResourcesAPI.Data;
using CorporateResourcesAPI.Repositories;
using CorporateResourcesAPI.Repositories.Interfaces;
using CorporateResourcesAPI.Services;
using CorporateResourcesAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CorporateResourcesAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Database connection
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Repositories settings
            builder.Services.AddScoped<IReservationRepository, ReservationRepository>();

            // Services settings
            builder.Services.AddScoped<IReservationService, ReservationService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
