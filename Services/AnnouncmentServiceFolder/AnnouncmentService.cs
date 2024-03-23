using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services.AnnouncmentServiceFolder
{
    public class AnnouncmentService : IAnnouncmentService
    {
        private readonly DataContext _context;
        public AnnouncmentService(DataContext context)
        {
            _context = context;
        }
        public async Task<Announcment> AddAnnouncment(AnnouncmentDto announcment)
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

        public async Task<ICollection<Announcment>> DeleteAnnouncment(Guid id)
        {
            var announcment = await _context.Announcments.FindAsync(id);
            if (announcment == null)
                return null;

            _context.Announcments.Remove(announcment);
            await _context.SaveChangesAsync();

            return await _context.Announcments.ToListAsync();
        }

        public async Task<ICollection<Announcment>> GetAnnouncments()
        {
            return await _context.Announcments.Include(x => x.Images).Include(x => x.Price).Include(x => x.Address).ToListAsync();
        }

        public async Task<Announcment> GetSingleAnnouncment(Guid id)
        {
            var announcment = await _context.Announcments.Include(x => x.Price).Include(x => x.Address).FirstOrDefaultAsync(x => x.Id == x.Id);
            if (announcment == null)
                return null;

            return announcment;
        }

        public async Task<Announcment> UpdateAnnouncment(Guid id, AnnouncmentDto newAnnouncment)
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
    }
}
