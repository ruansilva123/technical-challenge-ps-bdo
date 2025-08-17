using CorporateResourcesAPI.Data;
using CorporateResourcesAPI.Models;
using CorporateResourcesAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CorporateResourcesAPI.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AppDbContext _appDbContext;

        public ReservationRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Reservation> CreateAsync(Reservation entity)
        {
            await _appDbContext.Reservations.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Reservation entity)
        {
            _appDbContext.Reservations.Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public IQueryable<Reservation> GetAll()
        {
            return _appDbContext.Reservations;
        }

        public async Task<List<Reservation>> GetAllAsync()
        {
            return await _appDbContext.Reservations.ToListAsync();
        }

        public async Task<Reservation?> GetByIdAsync(int id)
        {
            return await _appDbContext.Reservations.FindAsync(id);
        }

        public async Task<Reservation> UpdateAsync(Reservation entity)
        {
            _appDbContext.Reservations.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
