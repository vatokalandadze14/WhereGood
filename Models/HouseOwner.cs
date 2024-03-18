using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Models
{
    public class HouseOwner : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int PhoneNumber { get; set; }
        public bool Agent { get; set; }
        public ICollection<Announcment> Announcments { get; set; }
    }
}
