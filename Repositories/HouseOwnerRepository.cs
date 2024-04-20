using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.Share;
using Microsoft.EntityFrameworkCore;

namespace HouseOwnerWebApi.Repositories
{
    public class HouseOwnerRepository : RepositoryBase<HouseOwner>, IHouseOwnerInterface
    {
        public HouseOwnerRepository(DataContext context) : base (context)
        {
        }

        public async Task<ICollection<HouseOwner>> GetAsync()
        {
            return await _context.HouseOwners
                .Include(a => a.Announcments)
                .Where(x => x.IsDeleted == false)
                .ToListAsync();
        }

        public async Task<HouseOwner?> GetOneAsync(Guid id)
        {
            var houseOwner = await _context.HouseOwners
                .Where(x => x.IsDeleted == false)
                .Include(x => x.Announcments)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (houseOwner == null)
                return null;

            return houseOwner;
        }

        public async Task<HouseOwner> AddAsync(HouseOwnerDto houseOwner)
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

        public async Task<HouseOwner?> UpdateAsync(Guid id, HouseOwnerDto houseOwner)
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

        public async Task<ICollection<HouseOwner>?> DeleteSingleAsync(Guid id)
        {
            var houseOwner = await _context.HouseOwners
                .Where(x => x.IsDeleted == false)
                .Include(x => x.Announcments)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (houseOwner == null)
                return null;

            houseOwner.IsDeleted = true;
            houseOwner.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return await _context.HouseOwners.ToListAsync();
        }
    }
}
