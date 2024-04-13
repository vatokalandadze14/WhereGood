using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IPortfolioInterface
    {
        public Task<ICollection<Portfolio>> GetAllAsync();
        public Task<Portfolio> GetSingleAsync(Guid id);
        public Task<Portfolio> AddAsync(PortfolioDto portfolio);
        public Task<Portfolio> UpdateAsync(Guid id, PortfolioDto portfolio);
        public Task<ICollection<Portfolio>> DeleteAsync(Guid id);
    }
}
