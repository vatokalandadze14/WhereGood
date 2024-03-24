using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services.PriceServiceFolder
{
    public class PriceService : IPriceService
    {
        private readonly DataContext _context;
        public PriceService(DataContext context)
        {
            _context = context;
        }
        public async Task<Price> AddPrice(PriceDto price)
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

        public async Task<ICollection<Price>> DeletePrice(Guid id)
        {
            var price = await _context.Prices.FindAsync(id);
            if (price == null)
                return null;

            price.IsDeleted = true;
            price.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return await _context.Prices.ToListAsync();
        }

        public async Task<Price> GetPrice(Guid id)
        {
            var price = await _context.Prices.FindAsync(id);
            if (price == null)
                return null;

            return price;
        }

        public async Task<ICollection<Price>> GetPrices()
        {
            return await _context.Prices.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<Price> UpdatePrise(Guid id, PriceDto price)
        {
            var newPrice = await _context.Prices.FindAsync(id);
            if (newPrice == null)
                return null;

            newPrice.SquareMeterGEL = price.SquareMeterGEL;
            newPrice.SquareMeterUSD = price.SquareMeterUSD;
            newPrice.TotalGEL = price.TotalGEL;
            newPrice.TotalUSD = price.TotalUSD;
            newPrice.AnnouncmentId = price.AnnouncmentId;

            await _context.SaveChangesAsync();
            return newPrice;
        }
    }
}
