using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.ServiceInterface
{
    public interface IAgencyService
    {
        public Task<ICollection<Agency>> GetAgencies();
        public Task<Agency?> GetAgency(Guid id);
        public Task<Agency> AddAgency(AgencyDto agency);
        public Task<Agency?> UpdateAgency(Guid id, AgencyDto agency);
        public Task<ICollection<Agency>?> DeleteAgency(Guid id);
    }
}
