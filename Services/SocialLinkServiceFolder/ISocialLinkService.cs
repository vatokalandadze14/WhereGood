using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.Services.SocialLinkServiceFolder
{
    public interface ISocialLinkService
    {
        public Task<ICollection<SocialLink>> GetSocialLinks();
        public Task<SocialLink> GetSocialLink(Guid id);
        public Task<SocialLink> AddSocialLink(SocialLinkDto socialLink);
        public Task<SocialLink> UpdateSocialLink(Guid id, SocialLinkDto socialLink);
        public Task<ICollection<SocialLink>> DeleteSocialLink(Guid id);
    }
}
;