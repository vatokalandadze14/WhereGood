using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Migrations;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IImageInterface
    {
        public Task<ICollection<Image>> GetAllAsync();
        public Task<Image> GetSingleAsync(Guid id);
        public Task<Image> AddAsync(ImageCreateDto image);
        public Task<Image> UpdateAsync(Guid id, ImageCreateDto image);
        public Task<ICollection<Image>> DeleteAsync(Guid id);
    }
}
