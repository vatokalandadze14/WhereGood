using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly DataContext _context;
        private readonly ICompanyInterface _company;
        public CompanyService(DataContext context, ICompanyInterface company)
        {
            _context = context;
            _company = company;
        }
        public async Task<ICollection<Company>> GetCompanies()
        {
            return await _company.GetAllAsync();
        }
        public async Task<Company> GetCompany(Guid id)
        {
            return await _company.GetSingleAsync(id);
        }
        public async Task<Company> AddCompany(CompanyDto company)
        {
            return await _company.AddAsync(company);
        }
        public async Task<Company> UpdateCompany(Guid id, CompanyDto company)
        {
            return await _company.UpdateAsync(id, company);
        }
        public async Task<ICollection<Company>> DeleteCompany(Guid id)
        {
            return await _company.DeleteAsync(id);
        }
    }
}
