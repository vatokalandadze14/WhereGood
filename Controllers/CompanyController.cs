using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Services.CompanyServiceFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOwnerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _service;
        public CompanyController(ICompanyService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<Company>>> GetCompanies()
        {
            return Ok(await _service.GetCompanies());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(Guid id)
        {
            return Ok(await _service.GetCompany(id));
        }
        [HttpPost]
        public async Task<ActionResult<Company>> AddCompany(CompanyDto company)
        {
            return Ok(await _service.AddCompany(company));
        }
        [HttpPut]
        public async Task<ActionResult<Company>> UpdateCompany(Guid id, CompanyDto company)
        {
            return Ok(await _service.UpdateCompany(id, company));
        }
        [HttpDelete]
        public async Task<ActionResult<ICollection<Company>>> DeleteCompany(Guid id)
        {
            return Ok(await _service.DeleteCompany(id));
        }
    }
}
