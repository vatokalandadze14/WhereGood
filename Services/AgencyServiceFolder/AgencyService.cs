using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services.AgencyServiceFolder
{
    public class AgencyService : IAgencyService
    {
        private readonly DataContext _context;
        public AgencyService(DataContext context)
        {
            _context = context;
        }
        public async Task<Agency> AddAgency(AgencyDto agency)
        {
            var agent = new Agency
            {
                Name = agency.Name,
                Mail = agency.Mail,
                PhoneNumber = agency.PhoneNumber,
                Site = agency.Site,
                Description = agency.Description
            };

            _context.Agencies.Add(agent);
            await _context.SaveChangesAsync();

            return agent;
        }

        public async Task<ICollection<Agency>> DeleteAgency(Guid id)
        {
            var agent = await _context.Agencies.FindAsync(id);
            if (agent == null)
                return null;

            agent.IsDeleted = true;
            agent.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.Agencies.Where(x => x.IsDeleted == false).Include(x => x.Address).Include(x => x.SocialLinks).ToListAsync();
        }

        public async Task<ICollection<Agency>> GetAgencies()
        {
            return await _context.Agencies.Where(x => x.IsDeleted == false).Include(x => x.Address).Include(x => x.SocialLinks).ToListAsync();
        }

        public async Task<Agency> GetAgency(Guid id)
        {
            var agent = await _context.Agencies.Where(x => x.IsDeleted == false).Include(x => x.Address).Include(x => x.SocialLinks).FirstOrDefaultAsync(x => x.Id == x.Id);
            if (agent == null)
                return null;

            return agent;
        }

        public async Task<Agency> UpdateAgency(Guid id, AgencyDto agency)
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
    }
}
