using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.ServiceInterface;
using HouseOwnerWebApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Services
{
    public class SocialLinkService : ISocialLinkService
    {
        private readonly DataContext _context;
        private readonly SocialLinkRepository _repository;
        public SocialLinkService(DataContext context, SocialLinkRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public async Task<SocialLink> AddSocialLink(SocialLinkDto socialLink)
        {
            return await _repository.AddAsync(socialLink);
        }

        public async Task<ICollection<SocialLink>> DeleteSocialLink(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<SocialLink> GetSocialLink(Guid id)
        {
            return await _repository.GetSingleAsync(id);
        }

        public async Task<ICollection<SocialLink>> GetSocialLinks()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<SocialLink> UpdateSocialLink(Guid id, SocialLinkDto socialLink)
        {
            return await _repository.UpdateAsync(id, socialLink);
        }
    }
}
