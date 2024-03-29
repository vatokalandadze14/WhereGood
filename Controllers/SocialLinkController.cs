using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Services.SocialLinkServiceFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOwnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialLinkController : ControllerBase
    {
        private readonly ISocialLinkService _socialLinkService;
        public SocialLinkController(ISocialLinkService socialLinkService)
        {
            _socialLinkService = socialLinkService;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<SocialLink>>> GetSocialLinks()
        {
            return Ok(await _socialLinkService.GetSocialLinks());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SocialLink>> GetSocialLink(Guid id)
        {
            return Ok(await _socialLinkService.GetSocialLink(id));
        }
        [HttpPost]
        public async Task<ActionResult<SocialLink>> AddSocialLink(SocialLinkDto socialLink)
        {
            return Ok(await _socialLinkService.AddSocialLink(socialLink));
        }
        [HttpPut]
        public async Task<ActionResult<SocialLink>> UpdateSocialLink(Guid id, SocialLinkDto socialLink)
        {
            return Ok(await _socialLinkService.UpdateSocialLink(id, socialLink));
        }
        [HttpDelete]
        public async Task<ActionResult<ICollection<SocialLink>>> DeleteSocialLink(Guid id)
        {
            return Ok(await _socialLinkService.DeleteSocialLink(id));
        }
    }
}
