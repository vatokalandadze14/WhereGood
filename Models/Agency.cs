using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Models
{
    public class Agency : BaseEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public int PhoneNumber { get; set; }
        public ICollection<SocialLink> SocialLinks { get; set; }
    }
}
