using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.ServiceInterface;
using HouseOwnerWebApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services
{
    public class AgencyService : IAgencyService
    {
        private readonly DataContext _context;
        private readonly AgencyRepository _agencyRepository;
        public AgencyService(DataContext context, AgencyRepository agencyRepository)
        {
            _context = context;
            _agencyRepository = agencyRepository;
        }
        public async Task<Agency> AddAgency(AgencyDto agency)
        {
            return await _agencyRepository.AddAsync(agency);
        }

        public async Task<ICollection<Agency>> DeleteAgency(Guid id)
        {
            return await _agencyRepository.DeleteAsync(id);
        }

        public async Task<ICollection<Agency>> GetAgencies()
        {
            return await _agencyRepository.GetAllAsync();
        }

        public async Task<Agency?> GetAgency(Guid id)
        {
            return await _agencyRepository.GetSingleAsync(id);
        }

        public async Task<Agency> UpdateAgency(Guid id, AgencyDto agency)
        {
            return await _agencyRepository.UpdateAsync(id, agency);
        }
    }
}
