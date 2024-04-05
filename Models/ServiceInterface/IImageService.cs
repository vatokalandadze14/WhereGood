using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.Models.ServiceInterface
{
    public interface IImageService
    {
        public Task<ICollection<Image>> GetImages();
        public Task<Image> GetImage(Guid id);
        public Task<Image> AddImage(ImageCreateDto image);
        public Task<Image> UpdateImage(Guid id, ImageCreateDto image);
        public Task<ICollection<Image>> DeleteImage(Guid id);
    }
}
