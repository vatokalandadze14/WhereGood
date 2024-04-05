using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOwnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncmentController : ControllerBase
    {
        private readonly IAnnouncmentService _announcmentService;
        public AnnouncmentController(IAnnouncmentService announcmentService)
        {
            _announcmentService = announcmentService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Announcment>>> GetAnnouncments()
        {
            return Ok(await _announcmentService.GetAnnouncments());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Announcment>> GetSingleAnnouncment(Guid id)
        {
            return Ok(await _announcmentService.GetSingleAnnouncment(id));
        }
        [HttpPost]
        public async Task<ActionResult<Announcment>> AddAnnouncment(AnnouncmentDto announcment)
        {
            return Ok(await _announcmentService.AddAnnouncment(announcment));
        }
        [HttpPut]
        public async Task<ActionResult<Announcment>> UpdateAnnouncment(Guid id, AnnouncmentDto announcment)
        {
            return Ok(await _announcmentService.UpdateAnnouncment(id, announcment));
        }
        [HttpDelete]
        public async Task<ActionResult<ICollection<Announcment>>> DeleteAnnouncment(Guid id)
        {
            return Ok(await _announcmentService.DeleteAnnouncment(id));
        }
    }
}
