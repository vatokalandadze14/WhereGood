using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HouseOwnerWebApi.Services.HouseOwnerServiceFolder
{
    public class HouseOwnerService : IHouseOwnerService
    {
        private readonly DataContext _context;
        public HouseOwnerService(DataContext context)
        {
            _context = context;
        }
        public async Task<HouseOwner> AddHouseOwner(HouseOwnerDto houseOwner)
        {
            var newHouseOwner = new HouseOwner
            {
                Name = houseOwner.name,
                SurName = houseOwner.surName,
                PhoneNumber = houseOwner.phoneNumber,
                Agent = houseOwner.agent,
            };
            
            _context.HouseOwners.Add(newHouseOwner);
            await _context.SaveChangesAsync();

            return newHouseOwner;
        }

        public async Task<ICollection<HouseOwner>> DeleteHouseOwner(Guid id)
        {
            var houseOwner = await _context.HouseOwners.FindAsync(id);
            if (houseOwner == null)
                return null;

            _context.HouseOwners.Remove(houseOwner);
            await _context.SaveChangesAsync();

            return await _context.HouseOwners.ToListAsync();
        }

        public async Task<ICollection<HouseOwner>> GetHouseOwners()
        {
            return await _context.HouseOwners.ToListAsync();
        }

        public async Task<HouseOwner> GetSingleHouseOwner(Guid id)
        {
            var houseOwner = await _context.HouseOwners.FindAsync(id);
            if (houseOwner == null)
                return null;

            return houseOwner;
        }

        public async Task<HouseOwner> UpdateHouseOwner(Guid id, HouseOwnerDto houseOwner)
        {
            var foundedHouseOwner = await _context.HouseOwners.FindAsync(id);
            if (foundedHouseOwner == null)
                return null;

            foundedHouseOwner.Name = houseOwner.name;
            foundedHouseOwner.SurName = houseOwner.surName;
            foundedHouseOwner.PhoneNumber = houseOwner.phoneNumber;
            foundedHouseOwner.Agent = houseOwner.agent;

            await _context.SaveChangesAsync();
            return foundedHouseOwner;
        }
    }
}
