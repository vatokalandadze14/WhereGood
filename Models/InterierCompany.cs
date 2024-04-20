using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Models
{
    public class InterierCompany : Company
    {
        public ICollection<Portfolio>? Portfolios { get; set; }
        public Guid PortfolioId { get; set; }
    }
}
