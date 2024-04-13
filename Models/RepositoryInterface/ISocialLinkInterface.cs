using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface ISocialLinkInterface
    {
        public Task<ICollection<SocialLink>> GetAllAsync();
        public Task<SocialLink> GetSingleAsync(Guid id);
        public Task<SocialLink> AddAsync(SocialLinkDto socialLink);
        public Task<SocialLink> UpdateAsync(Guid id, SocialLinkDto socialLink);
        public Task<ICollection<SocialLink>> DeleteAsync(Guid id);
    }
}
