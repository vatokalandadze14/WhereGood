using HouseOwnerWebApi.Data;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Models.Share
{
    public class RepositoryBase <T> where T : BaseEntity
    {
        protected DataContext _context;
        protected RepositoryBase(DataContext context) { 
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().Where(x => !x.IsDeleted).ToListAsync();
        }

        public async Task<T?> GetSingleAsync(Guid id)
        {
            return await _context.Set<T>().Where(x => !x.IsDeleted && x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<T> AddAsync(T t)
        {
            await _context.Set<T>().AddAsync(t);
            await _context.SaveChangesAsync();
            return t;
        }

        public async Task<T?> UpdateAsync(Guid id, T t)
        {
            var existingEntity = await _context.Set<T>().FindAsync(id);
            if (existingEntity == null)
                return null;

            _context.Entry(existingEntity).CurrentValues.SetValues(t);
            await _context.SaveChangesAsync();
            return t;
        }

        public async Task<ICollection<T>?> DeleteAsync(Guid id)
        {
            var existingEntity = await _context.Set<T>().FindAsync(id);
            if (existingEntity == null)
                return null;


            existingEntity.IsDeleted = true;
            existingEntity.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return await _context.Set<T>().Where(x => x.IsDeleted == false).ToListAsync();  
        }
    }
}
