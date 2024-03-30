using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services.PortfolioServiceFolder
{
    public class PortfolioService : IPortfolioService
    {
        private readonly DataContext _context;
        public PortfolioService(DataContext context)
        {
            _context = context;
        }
        public async Task<ICollection<Portfolio>> GetPortfolios()
        {
            return await _context.Portfolios.Where(x => x.IsDeleted == false).ToListAsync();
        }
        public async Task<Portfolio> GetPortfolio(Guid id)
        {
            var portfolio = await _context.Portfolios.Where(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == id);
            if (portfolio == null)
                return null;

            return portfolio;
        }
        public async Task<Portfolio> AddPortfolio(PortfolioDto portfolio)
        {
            var newPortfolio = new Portfolio
            {
                Title = portfolio.Title,
                HtmlDescription = portfolio.HtmlDescription,
                InterierCompanyId = portfolio.InterierCompanyId
            };

            _context.Portfolios.Add(newPortfolio);
            await _context.SaveChangesAsync();

            return newPortfolio;
        }
        public async Task<Portfolio> UpdatePortfolio(Guid id, PortfolioDto portfolio)
        {
            var newPortfolio = await _context.Portfolios.FindAsync(id);
            if (newPortfolio == null)
                return null;

            newPortfolio.Title = portfolio.Title;
            newPortfolio.HtmlDescription = portfolio.HtmlDescription;

            await _context.SaveChangesAsync();

            return newPortfolio;
        }
        public async Task<ICollection<Portfolio>> DeletePortfolio(Guid id)
        {
            var portfolio = await _context.Portfolios.Where(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == id);
            if (portfolio == null)
                return null;

            portfolio.IsDeleted = true;
            portfolio.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.Portfolios.ToListAsync();
        }
    }
}
