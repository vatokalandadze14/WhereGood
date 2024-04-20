using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IPriceInterface
    {
        public Task<ICollection<Price>> GetAsync();
        public Task<Price?> GetOneAsync(Guid id);
        public Task<Price> AddAsync(PriceDto price);
        public Task<Price?> UpdateAsync(Guid id, PriceDto price);
        public Task<ICollection<Price>?> DeleteSingleAsync(Guid id);
    }
}
