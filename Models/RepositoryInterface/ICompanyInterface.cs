using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface ICompanyInterface
    {
        public Task<ICollection<Company>> GetAsync();
        public Task<Company?> GetOneAsync(Guid id);
        public Task<Company> AddAsync(CompanyDto address);
        public Task<Company?> UpdateAsync(Guid id, CompanyDto address);
        public Task<ICollection<Company>?> DeleteSingleAsync(Guid id);
    }
}
