using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.Models.ServiceInterface
{
    public interface ICompanyService
    {
        public Task<ICollection<Company>> GetCompanies();
        public Task<Company> GetCompany(Guid id);
        public Task<Company> AddCompany(CompanyDto company);
        public Task<Company> UpdateCompany(Guid id, CompanyDto company);
        public Task<ICollection<Company>> DeleteCompany(Guid id);
    }
}
