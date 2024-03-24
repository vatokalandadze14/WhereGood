using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Services.AddressServiceFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOwnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<Address>>> GetAddresses()
        {
            return Ok(await _addressService.GetAddresses());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddress(Guid id)
        {
            return Ok(await _addressService.GetAddress(id));
        }
        [HttpPost]
        public async Task<ActionResult<Address>> AddAddress(AddressDto address)
        {
            return Ok(await _addressService.AddAddress(address));
        }
        [HttpPut]
        public async Task<ActionResult<Address>> UpdateAddress(Guid id, AddressDto address)
        {
            return Ok(await _addressService.UpdateAddress(id, address));
        }
        [HttpDelete]
        public async Task<ActionResult<ICollection<Address>>> DeleteAddress(Guid id)
        {
            return Ok(await _addressService.DeleteAddress(id));
        }
    }
}
