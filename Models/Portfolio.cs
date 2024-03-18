using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Models
{
    public class Portfolio : BaseEntity
    {
        public string Title { get; set; }
        public string HtmlDescription { get; set; }

        public Guid InterierCompanyId { get; set; }
    }
}
