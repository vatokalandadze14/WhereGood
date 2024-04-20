using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IInterierCompanyInterface
    {
        public Task<ICollection<InterierCompany>> GetAsync();
        public Task<InterierCompany?> GetOneAsync(Guid id);
        public Task<InterierCompany> AddAsync(InterierCompanyDto interierCompany);
        public Task<InterierCompany?> UpdateAsync(Guid id, InterierCompanyDto interierCompany);
        public Task<ICollection<InterierCompany>?> DeleteSingleAsync(Guid id);
    }
}
