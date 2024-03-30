using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Services.InterierCompaniesServiceFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOwnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterierCompanyController : ControllerBase
    {
        private readonly IInterierCompanyService _service;
        public InterierCompanyController(IInterierCompanyService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<InterierCompany>>> GetInterierCompanies()
        {
            return Ok(await _service.GetInterierCompanies());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<InterierCompany>> GetInterierCompany(Guid id)
        {
            return Ok(await _service.GetInterierCompany(id));
        }
        [HttpPost]
        public async Task<ActionResult<InterierCompany>> AddInterierCompany(InterierCompanyDto interierCompany)
        {
            return Ok(await _service.AddInterierCompany(interierCompany));
        }
        [HttpPut]
        public async Task<ActionResult<InterierCompany>> UpdateInterierCompany(Guid id, InterierCompanyDto interierCompany)
        {
            return Ok(await _service.UpdateInterierCompany(id, interierCompany));
        }
        [HttpDelete]
        public async Task<ActionResult<ICollection<InterierCompany>>> DeleteInterierCompany(Guid id)
        {
            return Ok(await _service.DeleteInterierCompany(id));
        }
    }
}
