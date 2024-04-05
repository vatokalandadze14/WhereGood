using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface ICompanyInterface
    {
        public Task<ICollection<Company>> GetAllAsync();
        public Task<Company> GetSingleAsync(Guid id);
        public Task<Company> AddAsync(CompanyDto address);
        public Task<Company> UpdateAsync(Guid id, CompanyDto address);
        public Task<ICollection<Company>> DeleteAsync(Guid id);
    }
}
