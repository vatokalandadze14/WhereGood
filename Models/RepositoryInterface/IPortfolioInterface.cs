using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IPortfolioInterface
    {
        public Task<ICollection<Portfolio>> GetAsync();
        public Task<Portfolio?> GetOneAsync(Guid id);
        public Task<Portfolio> AddAsync(PortfolioDto portfolio);
        public Task<Portfolio?> UpdateAsync(Guid id, PortfolioDto portfolio);
        public Task<ICollection<Portfolio>?> DeleteSingleAsync(Guid id);
    }
}
