using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.Models.ServiceInterface
{
    public interface IAnnouncmentService
    {
        public Task<ICollection<Announcment>> GetAnnouncments();
        public Task<Announcment?> GetSingleAnnouncment(Guid id);
        public Task<Announcment> AddAnnouncment(AnnouncmentDto announcment);
        public Task<Announcment?> UpdateAnnouncment(Guid id, AnnouncmentDto announcment);
        public Task<ICollection<Announcment>?> DeleteAnnouncment(Guid id);
    }
}
