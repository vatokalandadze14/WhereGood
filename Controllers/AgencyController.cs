using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Services.AgencyServiceFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOwnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {
        private readonly IAgencyService _service;
        public AgencyController(IAgencyService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<Agency>>> GetAgencies()
        {
            return Ok(await _service.GetAgencies());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Agency>> GetAgency(Guid id)
        {
            return Ok(await _service.GetAgency(id));
        }
        [HttpPost]
        public async Task<ActionResult<Agency>> AddAgency(AgencyDto agency)
        {
            return Ok(await _service.AddAgency(agency));
        }
        [HttpPut]
        public async Task<ActionResult<Agency>> UpdateAgency(Guid id, AgencyDto agency)
        {
            return Ok(await _service.UpdateAgency(id, agency));
        }
        [HttpDelete]
        public async Task<ActionResult<ICollection<Agency>>> DeleteAgency(Guid id)
        {
            return Ok(await _service.DeleteAgency(id));
        }
    }
}
