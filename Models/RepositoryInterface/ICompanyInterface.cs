namespace HouseOwnerWebApi.Models.RepositoryInterface
{
    public interface ICompanyInterface
    {
        public Task<List<Company>> AddCompany(Company entity);
    }
}
