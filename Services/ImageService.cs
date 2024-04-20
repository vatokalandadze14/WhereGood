using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;
using HouseOwnerWebApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageInterface _repository;
        public ImageService(IImageInterface repository)
        {
            _repository = repository;
        }
        public async Task<Image> AddImage(ImageCreateDto image)
        {
            return await _repository.AddAsync(image);
        }

        public async Task<ICollection<Image>?> DeleteImage(Guid id)
        {
            return await _repository.DeleteSingleAsync(id);
        }

        public async Task<Image?> GetImage(Guid id)
        {
            return await _repository.GetOneAsync(id);
        }

        public async Task<ICollection<Image>> GetImages()
        {
            return await _repository.GetAsync();
        }

        public async Task<Image?> UpdateImage(Guid id, ImageCreateDto image)
        {
            return await _repository.UpdateAsync(id, image);
        }
    }
}
