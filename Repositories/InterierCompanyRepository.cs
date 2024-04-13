using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.DTOs;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Repositories
{
    public class InterierCompanyRepository : RepositoryBase<InterierCompany>, IInterierCompanyInterface
    {
        public InterierCompanyRepository(DataContext context) : base(context)
        {
        }

        public async Task<InterierCompany> AddAsync(InterierCompanyDto interierCompany)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<InterierCompany>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<InterierCompany>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<InterierCompany> GetSingleAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<InterierCompany> UpdateAsync(Guid id, InterierCompanyDto interierCompany)
        {
            throw new NotImplementedException();
        }
    }
}
