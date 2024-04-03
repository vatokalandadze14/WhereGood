
namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface IAgencyInterface
    {
        public Task<List<Agency>> GetAll();
    }
}
