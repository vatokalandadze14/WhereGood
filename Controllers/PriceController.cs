using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOwnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        private readonly IPriceService priceService;
        public PriceController(IPriceService priceService)
        {
            this.priceService = priceService;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<Price>>> GetPrices()
        {
            return Ok(await priceService.GetPrices());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Price>> GetPrice(Guid id)
        {
            return Ok(await priceService.GetPrice(id));
        }
        [HttpPost]
        public async Task<ActionResult<Price>> AddPrice(PriceDto price)
        {
            return Ok(await priceService.AddPrice(price));
        }
        [HttpPut]
        public async Task<ActionResult<Price>> UpdatePrice(Guid id, PriceDto price)
        {
            return Ok(await priceService.UpdatePrise(id, price));
        }
        [HttpDelete]
        public async Task<ActionResult<ICollection<Price>>> DeletePrice(Guid id)
        {
            return Ok(await priceService.DeletePrice(id));
        }
    }
}
