using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.Share;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Repositories
{
    public class SocialLinkRepository : RepositoryBase<SocialLink>, ISocialLinkInterface
    {
        public SocialLinkRepository(DataContext context) : base(context)
        {
        }

        public async Task<ICollection<SocialLink>> GetAsync()
        {
            return await _context.SocialLinks.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<SocialLink?> GetOneAsync(Guid id)
        {
            var socialLink = await _context.SocialLinks
                .Where(x => x.IsDeleted == false)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (socialLink == null)
                return null;

            return socialLink;
        }

        public async Task<SocialLink> AddAsync(SocialLinkDto socialLink)
        {
            var newSocialLink = new SocialLink
            {
                Type = socialLink.Type,
                Url = socialLink.Url,
                AgencyId = socialLink.AgencyId,
                CompanyId = socialLink.CompanyId
            };

            _context.SocialLinks.Add(newSocialLink);
            await _context.SaveChangesAsync();

            return newSocialLink;
        }

        public async Task<SocialLink?> UpdateAsync(Guid id, SocialLinkDto socialLink)
        {
            var newSocialLink = await _context.SocialLinks
                .Where(x => x.IsDeleted == false)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (newSocialLink == null)
                return null;

            newSocialLink.Type = socialLink.Type;
            newSocialLink.Url = socialLink.Url;

            await _context.SaveChangesAsync();

            return newSocialLink;
        }

        public async Task<ICollection<SocialLink>?> DeleteSingleAsync(Guid id)
        {
            var socialLink = await _context.SocialLinks
               .Where(x => x.IsDeleted == false)
               .FirstOrDefaultAsync(x => x.Id == id);

            if (socialLink == null)
                return null;

            socialLink.IsDeleted = true;
            socialLink.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.SocialLinks.ToListAsync();
        }
    }
}
