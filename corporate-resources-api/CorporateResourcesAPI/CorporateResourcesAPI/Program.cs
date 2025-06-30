using CorporateResources.Application.Reservations.Services;
using CorporateResources.Domain.Reservations.Models;
using CorporateResources.Domain.Reservations.Repositories;
using CorporateResources.Domain.Reservations.Services;
using CorporateResources.Infrastructure.Data;
using CorporateResources.Infrastructure.Reservations.Repositories;
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

            builder.Services.AddScoped<IReservationsReporitory, ReservationRepository>();
            builder.Services.AddScoped<IReservationsService, ReservationService>();

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("CorporateResources.Infrastructure")
                );
            });

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
