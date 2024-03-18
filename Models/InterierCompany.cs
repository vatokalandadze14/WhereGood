using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Models
{
    public class InterierCompany : BaseEntity
    {
        public ICollection<Portfolio> Portfolios { get; set; }
    }
}
