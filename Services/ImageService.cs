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
        private readonly DataContext _context;
        private readonly IImageInterface _repository;
        public ImageService(DataContext context, IImageInterface repository)
        {
            _context = context;
            _repository = repository;
        }
        public async Task<Image> AddImage(ImageCreateDto image)
        {
            return await _repository.AddAsync(image);
        }

        public async Task<ICollection<Image>> DeleteImage(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<Image> GetImage(Guid id)
        {
            return await _repository.GetSingleAsync(id);
        }

        public async Task<ICollection<Image>> GetImages()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Image> UpdateImage(Guid id, ImageCreateDto image)
        {
            return await _repository.UpdateAsync(id, image);
        }
    }
}
