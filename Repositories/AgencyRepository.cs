using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.Share;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Repositories
{
    public class AgencyRepository : RepositoryBase<Agency>, IAgencyRepository
    {
        public AgencyRepository(DataContext context) : base (context)
        {
        }
        public async Task<ICollection<Agency>> GetAsync()
        {
            return await _context.Agencies.Where(x => x.IsDeleted == false).ToListAsync();
        }
        public async Task<Agency?> GetOneAsync(Guid id)
        {
            return await _context.Agencies.Where(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Agency> AddAsync(AgencyDto agency)
        {
            var agent = new Agency
            {
                Name = agency.Name,
                Mail = agency.Mail,
                PhoneNumber = agency.PhoneNumber,
                Site = agency.Site,
                Description = agency.Description,
                AddressId = agency.AddressId,
                SocialLinksId = agency.SocialLinksId
            };

            _context.Agencies.Add(agent);
            await _context.SaveChangesAsync();

            return agent;
        }
        public async Task<Agency?> UpdateAsync(Guid id, AgencyDto agency)
        {
            var agent = await _context.Agencies.FindAsync(id);
            if (agent == null)
                return null;

            agent.Name = agency.Name;
            agent.Mail = agency.Mail;
            agent.PhoneNumber = agency.PhoneNumber;
            agent.Site = agency.Site;
            agent.Description = agency.Description;

            await _context.SaveChangesAsync();

            return agent;
        }
        public async Task<ICollection<Agency>?> DeleteSingleAsync(Guid id)
        {
            var agent = await _context.Agencies.FindAsync(id);
            if (agent == null)
                return null;

            agent.IsDeleted = true;
            agent.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.Agencies.Where(x => x.IsDeleted == false)
                .Include(x => x.Address)
                .Include(x => x.SocialLinks)
                .ToListAsync();
        }
    }
}
