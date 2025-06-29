using CorporateResources.Domain.Cities.Models;
using CorporateResources.Domain.Countries.Models;
using CorporateResources.Domain.Locations.Models;
using CorporateResources.Domain.Reservations.Models;
using CorporateResources.Domain.ResourceCategories.Models;
using CorporateResources.Domain.Resources.Models;
using CorporateResources.Domain.States.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporateResources.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ResourceCategory> ResourceCategories { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
