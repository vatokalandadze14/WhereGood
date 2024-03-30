using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Services.PortfolioServiceFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOwnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioService _service;
        public PortfolioController(IPortfolioService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<Portfolio>>> GetPortfolios()
        {
            return Ok(await _service.GetPortfolios());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Portfolio>> GetPortfolio(Guid Id)
        {
            return Ok(await _service.GetPortfolio(Id));
        }
        [HttpPost]
        public async Task<ActionResult<Portfolio>> AddPortfolio(PortfolioDto portfolio)
        {
            return Ok(await _service.AddPortfolio(portfolio));
        }
        [HttpPut]
        public async Task<ActionResult<Portfolio>> UpdatePortfolio(Guid Id, PortfolioDto portfolio)
        {
            return Ok(await _service.UpdatePortfolio(Id, portfolio));
        }
        [HttpDelete]
        public async Task<ActionResult<ICollection<Portfolio>>> DeletePortfolio(Guid id)
        {
            return Ok(await _service.DeletePortfolio(id));
        }
    }
}
