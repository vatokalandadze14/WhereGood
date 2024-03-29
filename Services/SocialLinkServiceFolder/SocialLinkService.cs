using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services.SocialLinkServiceFolder
{
    public class SocialLinkService : ISocialLinkService
    {
        private readonly DataContext _context;
        public SocialLinkService(DataContext context)
        {
            _context = context;
        }

        public async Task<SocialLink> AddSocialLink(SocialLinkDto socialLink)
        {
            var newSocialLink = new SocialLink
            {
                Type = socialLink.Type,
                Url = socialLink.Url,
                AgencyId = socialLink.AgencyId
            };

            _context.SocialLinks.Add(newSocialLink);
            await _context.SaveChangesAsync();

            return newSocialLink;
        }

        public async Task<ICollection<SocialLink>> DeleteSocialLink(Guid id)
        {
            var socialLink = await _context.SocialLinks.FindAsync(id);
            if (socialLink == null)
                return null;

            socialLink.IsDeleted = true;
            socialLink.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.SocialLinks.ToListAsync();
        }

        public async Task<SocialLink> GetSocialLink(Guid id)
        {
            var socialLink = await _context.SocialLinks.FindAsync(id);
            if (socialLink == null)
                return null;

            return socialLink;
        }

        public async Task<ICollection<SocialLink>> GetSocialLinks()
        {
            return await _context.SocialLinks.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<SocialLink> UpdateSocialLink(Guid id, SocialLinkDto socialLink)
        {
            var newSocialLink = await _context.SocialLinks.FindAsync(id);
            if (newSocialLink == null)
                return null;

            newSocialLink.Type = socialLink.Type;
            newSocialLink.Url = socialLink.Url;

            await _context.SaveChangesAsync();

            return newSocialLink;
        }
    }
}
