using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.Services.InterierCompaniesServiceFolder
{
    public interface IInterierCompanyService
    {
        public Task<ICollection<InterierCompany>> GetInterierCompanies();
        public Task<InterierCompany> GetInterierCompany(Guid id);
        public Task<InterierCompany> AddInterierCompany(InterierCompanyDto InterierCompany);
        public Task<InterierCompany> UpdateInterierCompany(Guid id, InterierCompanyDto InterierCompany);
        public Task<ICollection<InterierCompany>> DeleteInterierCompany(Guid id);
    }
}
