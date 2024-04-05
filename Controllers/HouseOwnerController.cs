using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOwnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseOwnerController : ControllerBase
    {
        private readonly IHouseOwnerService _houseOwnerService;
        public HouseOwnerController(IHouseOwnerService houseOwnerService)
        {
            _houseOwnerService = houseOwnerService;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<HouseOwner>>> GetHouseOwners()
        {
            return Ok(await _houseOwnerService.GetHouseOwners());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ICollection<HouseOwner>>> GetHouseOwner(Guid id)
        {
            return Ok(await _houseOwnerService.GetSingleHouseOwner(id));
        }
        [HttpPost]
        public async Task<ActionResult<HouseOwner>> AddHouseOwner(HouseOwnerDto houseOwner)
        {
            return Ok(await _houseOwnerService.AddHouseOwner(houseOwner));
        }
        [HttpDelete]
        public async Task<ActionResult<List<HouseOwner>>> DeleteHouseOwner(Guid id)
        {
            return Ok(await _houseOwnerService.DeleteHouseOwner(id));
        }
        [HttpPut]
        public async Task<ActionResult<HouseOwner>> UpdateHouseOwner(Guid id, HouseOwnerDto houseOwner)
        {
            return Ok(await _houseOwnerService.UpdateHouseOwner(id, houseOwner));
        }
    }
}
