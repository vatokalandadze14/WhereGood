using HouseOwnerWebApi.DTOs;

namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface ISocialLinkInterface
    {
        public Task<ICollection<SocialLink>> GetAsync();
        public Task<SocialLink?> GetOneAsync(Guid id);
        public Task<SocialLink> AddAsync(SocialLinkDto socialLink);
        public Task<SocialLink?> UpdateAsync(Guid id, SocialLinkDto socialLink);
        public Task<ICollection<SocialLink>?> DeleteSingleAsync(Guid id);
    }
}
