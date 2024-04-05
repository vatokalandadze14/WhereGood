using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.Share;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Repositories
{
    public class AnnouncmentRepository : RepositoryBase<Announcment>, IAnnouncmentInterface
    {
        public AnnouncmentRepository(DataContext context) : base (context)
        {
        }

        public async Task<ICollection<Announcment>> GetAllAsync()
        {
            return await _context.Announcments
                .Include(x => x.Images)
                .Include(x => x.Price)
                .Include(x => x.Address)
                .Where(x => x.IsDeleted == false)
                .ToListAsync();
        }

        public async Task<Announcment> GetSingleAsync(Guid id)
        {
            var announcment = await _context.Announcments
                .Include(x => x.Price)
                .Include(x => x.Address)
                .FirstOrDefaultAsync(x => x.Id == x.Id);

            if (announcment == null)
                return null;

            return announcment;
        }

        public async Task<Announcment> AddAsync(AnnouncmentDto announcment)
        {
            var newAnnouncment = new Announcment
            {
                Title = announcment.title,
                Description = announcment.description,
                ShortDescription = announcment.shortDescription,
                Type = announcment.type,
                PropertyType = announcment.propertyType
            };

            _context.Announcments.Add(newAnnouncment);
            await _context.SaveChangesAsync();

            return newAnnouncment;
        }

        public async Task<Announcment> UpdateAsync(Guid id, AnnouncmentDto newAnnouncment)
        {
            var announcment = await _context.Announcments.FindAsync(id);
            if (announcment == null)
                return null;

            announcment.Title = newAnnouncment.title;
            announcment.Description = newAnnouncment.description;
            announcment.ShortDescription = newAnnouncment.shortDescription;
            announcment.Type = newAnnouncment.type;
            announcment.PropertyType = newAnnouncment.propertyType;

            await _context.SaveChangesAsync();

            return announcment;
        }

        public async Task<ICollection<Announcment>> DeleteAsync(Guid id)
        {
            var announcment = await _context.Announcments.FindAsync(id);
            if (announcment == null)
                return null;

            announcment.IsDeleted = true;
            announcment.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return await _context.Announcments
                .Include(x => x.Images)
                .Include(x => x.Price)
                .Include(x => x.Address)
                .Where(x => x.IsDeleted == false)
                .ToListAsync();
        }
    }
}
