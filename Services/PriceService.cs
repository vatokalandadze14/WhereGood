using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;

namespace HouseOwnerWebApi.Services
{
    public class PriceService : IPriceService
    {
        private readonly IPriceInterface _repository;
        public PriceService(IPriceInterface repository)
        {
            _repository = repository;
        }
        public async Task<Price> AddPrice(PriceDto price)
        {
            return await _repository.AddAsync(price);
        }

        public async Task<ICollection<Price>?> DeletePrice(Guid id)
        {
            return await _repository.DeleteSingleAsync(id);
        }

        public async Task<Price?> GetPrice(Guid id)
        {
            return await _repository.GetOneAsync(id);
        }

        public async Task<ICollection<Price>> GetPrices()
        {
            return await _repository.GetAsync();
        }

        public async Task<Price?> UpdatePrice(Guid id, PriceDto price)
        {
            return await _repository.UpdateAsync(id, price);
        }
    }
}
