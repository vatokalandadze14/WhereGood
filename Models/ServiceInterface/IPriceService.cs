using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.Models.ServiceInterface
{
    public interface IPriceService
    {
        public Task<ICollection<Price>> GetPrices();
        public Task<Price?> GetPrice(Guid id);
        public Task<Price> AddPrice(PriceDto price);
        public Task<Price?> UpdatePrice(Guid id, PriceDto price);
        public Task<ICollection<Price>?> DeletePrice(Guid id);
    }
}
