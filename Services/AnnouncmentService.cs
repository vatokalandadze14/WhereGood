using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;

namespace HouseOwnerWebApi.Services
{
    public class AnnouncmentService : IAnnouncmentService
    {
        private readonly IAnnouncmentInterface _announcment;
        public AnnouncmentService(IAnnouncmentInterface announcment)
        {
            _announcment = announcment;
        }
        public async Task<Announcment> AddAnnouncment(AnnouncmentDto announcment)
        {
            return await _announcment.AddAsync(announcment);
        }

        public async Task<ICollection<Announcment>?> DeleteAnnouncment(Guid id)
        {
            return await _announcment.DeleteSingleAsync(id);
        }

        public async Task<ICollection<Announcment>> GetAnnouncments()
        {
            return await _announcment.GetAsync();
        }

        public async Task<Announcment?> GetSingleAnnouncment(Guid id)
        {
            return await _announcment.GetOneAsync(id);
        }

        public async Task<Announcment?> UpdateAnnouncment(Guid id, AnnouncmentDto newAnnouncment)
        {
            return await _announcment.UpdateAsync(id, newAnnouncment);
        }
    }
}
