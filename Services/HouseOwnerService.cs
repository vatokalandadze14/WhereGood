using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;
using HouseOwnerWebApi.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HouseOwnerWebApi.Services
{
    public class HouseOwnerService : IHouseOwnerService
    {
        private readonly DataContext _context;
        private readonly IHouseOwnerInterface _repository;
        public HouseOwnerService(DataContext context, IHouseOwnerInterface repository)
        {
            _context = context;
            _repository = repository;
        }
        public async Task<HouseOwner> AddHouseOwner(HouseOwnerDto houseOwner)
        {
            return await _repository.AddAsync(houseOwner);
        }

        public async Task<ICollection<HouseOwner>> DeleteHouseOwner(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ICollection<HouseOwner>> GetHouseOwners()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<HouseOwner> GetSingleHouseOwner(Guid id)
        {
            return await _repository.GetSingleAsync(id);
        }

        public async Task<HouseOwner> UpdateHouseOwner(Guid id, HouseOwnerDto houseOwner)
        {
            return await _repository.UpdateAsync(id, houseOwner);
        }
    }
}
