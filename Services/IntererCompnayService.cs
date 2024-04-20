using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services
{
    public class InterierCompanyService : IInterierCompanyService
    {
        private readonly IInterierCompanyInterface _repostiroy;
        public InterierCompanyService(IInterierCompanyInterface repostiroy)
        {
            _repostiroy = repostiroy;
        }
        public async Task<ICollection<InterierCompany>> GetInterierCompanies()
        {
            return await _repostiroy.GetAsync();
        }
        public async Task<InterierCompany?> GetInterierCompany(Guid id)
        {
            return await _repostiroy.GetOneAsync(id);
        }
        public async Task<InterierCompany> AddInterierCompany(InterierCompanyDto company)
        {
            return await _repostiroy.AddAsync(company);
        }
        public async Task<InterierCompany?> UpdateInterierCompany(Guid id, InterierCompanyDto company)
        {
            return await _repostiroy.UpdateAsync(id, company);
        }
        public async Task<ICollection<InterierCompany>?> DeleteInterierCompany(Guid id)
        {
            return await _repostiroy.DeleteSingleAsync(id);
        }
    }
}
