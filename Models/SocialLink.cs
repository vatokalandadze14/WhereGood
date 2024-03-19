using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Models
{
    public class SocialLink : BaseEntity
    {
        public SocialEnum Type { get; set; }
        public string Url { get; set; }

        public Guid? AgencyId { get; set; }
    }
}
