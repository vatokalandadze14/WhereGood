using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Models
{
    public class Address : BaseEntity
    {
        public string? City { get; set; }
        public string? Municipality { get; set; }
        public double Longitude { get; set; }
        public double Latitute { get; set; }
        public string? Region { get; set; }
        public string? District { get; set; }
        public string Street { get; set; }
        public string? StreetNumber { get; set; }
        public Guid AnnouncmentId { get; set; }
        public Guid AgencyId { get; set; }
    }
}
