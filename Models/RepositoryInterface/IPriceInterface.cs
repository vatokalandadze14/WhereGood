using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IPriceInterface
    {
        public Task<ICollection<Price>> GetAllAsync();
        public Task<Price> GetSingleAsync(Guid id);
        public Task<Price> AddAsync(PriceDto price);
        public Task<Price> UpdateAsync(Guid id, PriceDto price);
        public Task<ICollection<Price>> DeleteAsync(Guid id);
    }
}
