using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services.InterierCompaniesServiceFolder
{
    public class InterierCompanyService : IInterierCompanyService
    {
        private readonly DataContext _context;
        public InterierCompanyService(DataContext context)
        {
            _context = context;
        }
        public async Task<ICollection<InterierCompany>> GetInterierCompanies()
        {
            return await _context.InterierCompanies.Where(x => x.IsDeleted == false).Include(x => x.SocialLinks).ToListAsync();
        }
        public async Task<InterierCompany> GetInterierCompany(Guid id)
        {
            var interierCompany = await _context.InterierCompanies.FindAsync(id);
            if (interierCompany == null)
                return null;

            return interierCompany;
        }
        public async Task<InterierCompany> AddInterierCompany(InterierCompanyDto company)
        {
            var interierCompany = new InterierCompany
            {
                Name = company.Name,
                Mail = company.Mail,
                PhoneNumber = company.PhoneNumber,
                Site = company.Site,
                Description = company.Description
            };

            _context.InterierCompanies.Add(interierCompany);
            await _context.SaveChangesAsync();

            return interierCompany;
        }
        public async Task<InterierCompany> UpdateInterierCompany(Guid id, InterierCompanyDto company)
        {
            var newCompany = await _context.InterierCompanies.FindAsync(id);
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
        public async Task<ICollection<InterierCompany>> DeleteInterierCompany(Guid id)
        {
            var InterierCompany = await _context.InterierCompanies.FindAsync(id);
            if (InterierCompany == null)
                return null;

            InterierCompany.IsDeleted = true;
            InterierCompany.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.InterierCompanies.Where(x => x.IsDeleted == false).Include(x => x.SocialLinks).ToListAsync();
        }
    }
}
