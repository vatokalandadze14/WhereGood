using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services.ImagesServiceFolder
{
    public class ImageService : IImageService
    {
        private readonly DataContext _context;
        public ImageService(DataContext context)
        {
            _context = context;
        }
        public async Task<Image> AddImage(ImageCreateDto image)
        {
            var newImage = new Image
            {
                Name = image.name,
                Url = image.url,
                AnnouncmentId = image.AnnouncmentId
            };

            _context.Images.Add(newImage);
            await _context.SaveChangesAsync();

            return newImage;
        }

        public async Task<ICollection<Image>> DeleteImage(Guid id)
        {
            var image = await _context.Images.FindAsync(id);
            if (image == null)
                return null;

            image.IsDeleted = true;
            image.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return await _context.Images.ToListAsync();
        }

        public async Task<Image> GetImage(Guid id)
        {
            var image = await _context.Images.FindAsync(id);
            if (image == null)
                return null;

            return image;
        }

        public async Task<ICollection<Image>> GetImages()
        {
            return await _context.Images.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<Image> UpdateImage(Guid id, ImageCreateDto image)
        {
            var newImage = await _context.Images.FindAsync(id);
            if (newImage == null)
                return null;

            newImage.Name = image.name;
            newImage.Url = image.url;
            newImage.AnnouncmentId = image.AnnouncmentId;

            await _context.SaveChangesAsync();
            return newImage;
        }
    }
}
