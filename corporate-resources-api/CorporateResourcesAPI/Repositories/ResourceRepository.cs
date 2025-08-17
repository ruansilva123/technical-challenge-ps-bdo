using CorporateResourcesAPI.Data;
using CorporateResourcesAPI.Models;
using CorporateResourcesAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CorporateResourcesAPI.Repositories
{
    public class ResourceRepository : IResourceRepository
    {
        private readonly AppDbContext _appDbContext;

        public ResourceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Resource> CreateAsync(Resource entity)
        {
            await _appDbContext.Resources.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Resource entity)
        {
            _appDbContext.Resources.Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public IQueryable<Resource> GetAll()
        {
            return _appDbContext.Resources;
        }

        public async Task<List<Resource>> GetAllAsync()
        {
            return await _appDbContext.Resources.ToListAsync();
        }

        public async Task<Resource?> GetByIdAsync(int id)
        {
            return await _appDbContext.Resources.FindAsync(id);
        }

        public async Task<Resource> UpdateAsync(Resource entity)
        {
            _appDbContext.Resources.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
