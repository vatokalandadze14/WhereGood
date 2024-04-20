using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.Share;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Repositories
{
    public class InterierCompanyRepository : RepositoryBase<InterierCompany>, IInterierCompanyInterface
    {
        public InterierCompanyRepository(DataContext context) : base(context)
        {
        }
        public async Task<InterierCompany> AddAsync(InterierCompanyDto interierCompany)
        {
            var newCompany = new InterierCompany
            {
                AddressId = interierCompany.AddressId,
                PortfolioId = interierCompany.PortfolioId,
                SocialLinksId = interierCompany.SocialLinkId
            };

            _context.Companies.Add(newCompany);
            await _context.SaveChangesAsync();

            return newCompany;
        }

        public async Task<ICollection<InterierCompany>?> DeleteSingleAsync(Guid id)
        {
            var company = await _context.InterierCompanies.FindAsync(id);
            if (company == null)
                return null;

            company.IsDeleted = true;
            company.DeletedAt = DateTime.Now;

            return await _context.InterierCompanies.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<ICollection<InterierCompany>> GetAsync()
        {
            return await _context.InterierCompanies.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<InterierCompany?> GetOneAsync(Guid id)
        {
            var company = await _context.InterierCompanies.Where(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == id);
            if (company == null)
                return null;

            return company;
        }

        public async Task<InterierCompany?> UpdateAsync(Guid id, InterierCompanyDto interierCompany)
        {
            var company = await _context.InterierCompanies.Where(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == id);
            if (company == null)
                return null;

            company.Name = interierCompany.Name;
            company.Mail = interierCompany.Mail;
            company.PhoneNumber = interierCompany.PhoneNumber;
            company.Site = interierCompany.Site;
            company.Description = interierCompany.Description;

            await _context.SaveChangesAsync();

            return company;
        }
    }
}
