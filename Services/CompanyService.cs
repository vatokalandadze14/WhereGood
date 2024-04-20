using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;

namespace HouseOwnerWebApi.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyInterface _company;
        public CompanyService(ICompanyInterface company)
        {
            _company = company;
        }
        public async Task<ICollection<Company>> GetCompanies()
        {
            return await _company.GetAsync();
        }
        public async Task<Company?> GetCompany(Guid id)
        {
            return await _company.GetOneAsync(id);
        }
        public async Task<Company> AddCompany(CompanyDto company)
        {
            return await _company.AddAsync(company);
        }
        public async Task<Company?> UpdateCompany(Guid id, CompanyDto company)
        {
            return await _company.UpdateAsync(id, company);
        }
        public async Task<ICollection<Company>?> DeleteCompany(Guid id)
        {
            return await _company.DeleteSingleAsync(id);
        }
    }
}
