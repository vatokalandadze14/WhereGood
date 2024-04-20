using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;

namespace HouseOwnerWebApi.Services
{
    public class AgencyService : IAgencyService
    {
        private readonly IAgencyRepository _agencyRepository;
        public AgencyService(IAgencyRepository agencyRepository)
        {
            _agencyRepository = agencyRepository;
        }
        public async Task<Agency> AddAgency(AgencyDto agency)
        {
            return await _agencyRepository.AddAsync(agency);
        }

        public async Task<ICollection<Agency>?> DeleteAgency(Guid id)
        {
            return await _agencyRepository.DeleteSingleAsync(id);
        }

        public async Task<ICollection<Agency>> GetAgencies()
        {
            return await _agencyRepository.GetAsync();
        }

        public async Task<Agency?> GetAgency(Guid id)
        {
            return await _agencyRepository.GetOneAsync(id);
        }

        public async Task<Agency?> UpdateAgency(Guid id, AgencyDto agency)
        {
            return await _agencyRepository.UpdateAsync(id, agency);
        }
    }
}
