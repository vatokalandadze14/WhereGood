using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.Share;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Repositories
{
    public class PortfolioRepository : RepositoryBase<Portfolio>, IPortfolioInterface
    {
        public PortfolioRepository(DataContext context) : base(context)
        {
        }

         public async Task<Portfolio> AddAsync(PortfolioDto portfolio)
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

        public async Task<ICollection<Portfolio>?> DeleteSingleAsync(Guid id)
        {
            var portfolio = await _context.Portfolios.Where(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == id);
            if (portfolio == null)
                return null;

            portfolio.IsDeleted = true;
            portfolio.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.Portfolios.ToListAsync();
        }

        public async Task<ICollection<Portfolio>> GetAsync()
        {
            return await _context.Portfolios.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<Portfolio?> GetOneAsync(Guid id)
        {
            var portfolio = await _context.Portfolios
                .Where(x => x.IsDeleted == false)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (portfolio == null)
                return null;

            return portfolio;
        }

        public async Task<Portfolio?> UpdateAsync(Guid id, PortfolioDto portfolio)
        {
            var newPortfolio = await _context.Portfolios.FindAsync(id);
            if (newPortfolio == null)
                return null;

            newPortfolio.Title = portfolio.Title;
            newPortfolio.HtmlDescription = portfolio.HtmlDescription;

            await _context.SaveChangesAsync();

            return newPortfolio;
        }
    }
}
