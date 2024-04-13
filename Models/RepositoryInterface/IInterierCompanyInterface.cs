using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IInterierCompanyInterface
    {
        public Task<ICollection<InterierCompany>> GetAllAsync();
        public Task<InterierCompany> GetSingleAsync(Guid id);
        public Task<InterierCompany> AddAsync(InterierCompanyDto interierCompany);
        public Task<InterierCompany> UpdateAsync(Guid id, InterierCompanyDto interierCompany);
        public Task<ICollection<InterierCompany>> DeleteAsync(Guid id);
    }
}
