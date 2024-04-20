using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IImageInterface
    {
        public Task<ICollection<Image>> GetAsync();
        public Task<Image?> GetOneAsync(Guid id);
        public Task<Image> AddAsync(ImageCreateDto image);
        public Task<Image?> UpdateAsync(Guid id, ImageCreateDto image);
        public Task<ICollection<Image>?> DeleteSingleAsync(Guid id);
    }
}
