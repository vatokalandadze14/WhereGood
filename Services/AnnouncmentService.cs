using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services
{
    public class AnnouncmentService : IAnnouncmentService
    {
        private readonly DataContext _context;
        private readonly IAnnouncmentInterface _announcment;
        public AnnouncmentService(DataContext context, IAnnouncmentInterface announcment)
        {
            _context = context;
            _announcment = announcment;
        }
        public async Task<Announcment> AddAnnouncment(AnnouncmentDto announcment)
        {
            return await _announcment.AddAsync(announcment);
        }

        public async Task<ICollection<Announcment>> DeleteAnnouncment(Guid id)
        {
            return await _announcment.DeleteAsync(id);
        }

        public async Task<ICollection<Announcment>> GetAnnouncments()
        {
            return await _announcment.GetAllAsync();
        }

        public async Task<Announcment> GetSingleAnnouncment(Guid id)
        {
            return await _announcment.GetSingleAsync(id);
        }

        public async Task<Announcment> UpdateAnnouncment(Guid id, AnnouncmentDto newAnnouncment)
        {
            return await _announcment.UpdateAsync(id, newAnnouncment);
        }
    }
}
