using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.Share;
using Microsoft.EntityFrameworkCore;
using Price = HouseOwnerWebApi.Models.Price;

namespace HouseOwnerWebApi.Repositories
{
    public class PriceRepository : RepositoryBase<Price>, IPriceInterface
    {
        public PriceRepository(DataContext context) : base (context)
        {
        }

        public async Task<ICollection<Price>> GetAsync()
        {
            return await _context.Prices.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<Price?> GetOneAsync(Guid id)
        {
            var price = await _context.Prices
                .Where(x => x.IsDeleted == false)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (price == null)
                return null;

            return price;
        }
        public async Task<Price> AddAsync(PriceDto price)
        {
            var newPrice = new Price
            {
                TotalGEL = price.TotalGEL,
                TotalUSD = price.TotalUSD,
                SquareMeterGEL = price.SquareMeterGEL,
                SquareMeterUSD = price.SquareMeterUSD,
                AnnouncmentId = price.AnnouncmentId
            };

            _context.Prices.Add(newPrice);
            await _context.SaveChangesAsync();

            return newPrice;
        }
        public async Task<Price?> UpdateAsync(Guid id, PriceDto price)
        {
            var newPrice = await _context.Prices.FindAsync(id);
            if (newPrice == null)
                return null;

            newPrice.SquareMeterGEL = price.SquareMeterGEL;
            newPrice.SquareMeterUSD = price.SquareMeterUSD;
            newPrice.TotalGEL = price.TotalGEL;
            newPrice.TotalUSD = price.TotalUSD;

            await _context.SaveChangesAsync();
            return newPrice;
        }
        public async Task<ICollection<Price>?> DeleteSingleAsync(Guid id)
        {
            var price = await _context.Prices
                .Where(x => x.IsDeleted == false)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (price == null)
                return null;

            price.IsDeleted = true;
            price.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return await _context.Prices.ToListAsync();
        }

    }
}
