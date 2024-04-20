using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.Share;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Repositories
{
    public class ImageRepository : RepositoryBase<Image>, IImageInterface
    {
        public ImageRepository(DataContext context) : base (context)
        {
        }

        public async Task<ICollection<Image>> GetAsync()
        {
            return await _context.Images.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<Image?> GetOneAsync(Guid id)
        {
            var image = await _context.Images
                .Where(x => x.IsDeleted == false)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (image == null)
                return null;

            return image;
        }

        public async Task<Image> AddAsync(ImageCreateDto image)
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

        public async Task<Image?> UpdateAsync(Guid id, ImageCreateDto image)
        {
            var newImage = await _context.Images.FindAsync(id);
            if (newImage == null)
                return null;

            newImage.Name = image.name;
            newImage.Url = image.url;

            await _context.SaveChangesAsync();
            return newImage;
        }

        public async Task<ICollection<Image>?> DeleteSingleAsync(Guid id)
        {
            var image = await _context.Images
                .Where(x => x.IsDeleted == false)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (image == null)
                return null;

            image.IsDeleted = true;
            image.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return await _context.Images.ToListAsync();
        }
    }
}
