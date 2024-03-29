using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Models
{
    public class Image : BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public Guid? AnnouncmentId { get; set; }
    }
}
