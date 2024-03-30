using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.Services.PortfolioServiceFolder
{
    public interface IPortfolioService
    {
        public Task<ICollection<Portfolio>> GetPortfolios();
        public Task<Portfolio> GetPortfolio(Guid id);
        public Task<Portfolio> AddPortfolio(PortfolioDto portfolio);
        public Task<Portfolio> UpdatePortfolio(Guid id, PortfolioDto portfolio);
        public Task<ICollection<Portfolio>> DeletePortfolio(Guid id);
    }
}
