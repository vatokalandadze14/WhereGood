using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IAnnouncmentInterface
    {
        public Task<ICollection<Announcment>> GetAsync();
        public Task<Announcment?> GetOneAsync(Guid id);
        public Task<Announcment> AddAsync(AnnouncmentDto announcment);
        public Task<Announcment?> UpdateAsync(Guid id, AnnouncmentDto announcment);
        public Task<ICollection<Announcment>?> DeleteSingleAsync(Guid id);
    }
}
