using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services.CompanyServiceFolder
{
    public class CompanyService : ICompanyService
    {
        private readonly DataContext _context;
        public CompanyService(DataContext context)
        {
            _context = context;
        }
        public async Task<ICollection<Company>> GetCompanies()
        {
            return await _context.Companies.Where(x => x.IsDeleted == false).Include(x => x.SocialLinks).ToListAsync();
        }
        public async Task<Company> GetCompany(Guid id)
        {
            var company = await _context.Companies.FindAsync(id);
            if (company == null)
                return null;

            return company;
        }
        public async Task<Company> AddCompany(CompanyDto company)
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
        public async Task<Company> UpdateCompany(Guid id, CompanyDto company)
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
        public async Task<ICollection<Company>> DeleteCompany(Guid id)
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
