using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.ServiceInterface;
using HouseOwnerWebApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services
{
    public class PriceService : IPriceService
    {
        private readonly DataContext _context;
        private readonly PriceRepository _repository;
        public PriceService(DataContext context, PriceRepository repository)
        {
            _context = context;
            _repository = repository;
        }
        public async Task<Price> AddPrice(PriceDto price)
        {
            return await _repository.AddAsync(price);
        }

        public async Task<ICollection<Price>> DeletePrice(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<Price> GetPrice(Guid id)
        {
            return await _repository.GetSingleAsync(id);
        }

        public async Task<ICollection<Price>> GetPrices()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Price> UpdatePrice(Guid id, PriceDto price)
        {
            return await _repository.UpdateAsync(id, price);
        }
    }
}
