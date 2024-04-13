using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services
{
    public class PortfolioService : IPortfolioService
    {
        private readonly DataContext _context;
        private readonly IPortfolioInterface _repository;
        public PortfolioService(DataContext context, IPortfolioInterface repository)
        {
            _context = context;
            _repository = repository;
        }
        public async Task<ICollection<Portfolio>> GetPortfolios()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<Portfolio> GetPortfolio(Guid id)
        {
            return await _repository.GetSingleAsync(id);
        }
        public async Task<Portfolio> AddPortfolio(PortfolioDto portfolio)
        {
            return await _repository.AddAsync(portfolio);
        }
        public async Task<Portfolio> UpdatePortfolio(Guid id, PortfolioDto portfolio)
        {
            return await _repository.UpdateAsync(id, portfolio);
        }
        public async Task<ICollection<Portfolio>> DeletePortfolio(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
