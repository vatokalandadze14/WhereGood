using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.Share;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Repositories
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyInterface
    {
        public CompanyRepository(DataContext context) : base (context)
        {
        }

        public async Task<ICollection<Company>> GetAllAsync()
        {
            return await _context.Companies.Where(x => x.IsDeleted == false).Include(x => x.SocialLinks).ToListAsync();
        }

        public async Task<Company> GetSingleAsync(Guid id)
        {
            var company = await _context.Companies
                .Where(x => x.IsDeleted == false)
                .Include(x => x.SocialLinks)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (company == null)
                return null;

            return company;
        }

        public async Task<Company> AddAsync(CompanyDto company)
        {
            var newCompany = new Company
            {
                Name = company.Name,
                Mail = company.Mail,
                PhoneNumber = company.PhoneNumber,
                Site = company.Site,
                Description = company.Description
            };

            _context.Companies.Add(newCompany);
            await _context.SaveChangesAsync();

            return newCompany;
        }

        public async Task<Company> UpdateAsync(Guid id, CompanyDto company)
        {
            var newCompany = await _context.Companies.FindAsync(id);
            if (newCompany == null)
                return null;

            newCompany.Name = company.Name;
            newCompany.Mail = company.Mail;
            newCompany.PhoneNumber = company.PhoneNumber;
            newCompany.Site = company.Site;
            newCompany.Description = company.Description;

            await _context.SaveChangesAsync();
            return newCompany;
        }

        public async Task<ICollection<Company>> DeleteAsync(Guid id)
        {
            var newCompany = await _context.Companies.FindAsync(id);
            if (newCompany == null)
                return null;

            newCompany.IsDeleted = true;
            newCompany.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.Companies.Where(x => x.IsDeleted == false).Include(x => x.SocialLinks).ToListAsync();
        }
    }
}
