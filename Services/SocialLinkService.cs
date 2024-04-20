using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;

namespace HouseOwnerWebApi.Services
{
    public class SocialLinkService : ISocialLinkService
    {
        private readonly ISocialLinkInterface _repository;
        public SocialLinkService(ISocialLinkInterface repository)
        {
            _repository = repository;
        }

        public async Task<SocialLink> AddSocialLink(SocialLinkDto socialLink)
        {
            return await _repository.AddAsync(socialLink);
        }

        public async Task<ICollection<SocialLink>?> DeleteSocialLink(Guid id)
        {
            return await _repository.DeleteSingleAsync(id);
        }

        public async Task<SocialLink?> GetSocialLink(Guid id)
        {
            return await _repository.GetOneAsync(id);
        }

        public async Task<ICollection<SocialLink>> GetSocialLinks()
        {
            return await _repository.GetAsync();
        }

        public async Task<SocialLink?> UpdateSocialLink(Guid id, SocialLinkDto socialLink)
        {
            return await _repository.UpdateAsync(id, socialLink);
        }
    }
}
