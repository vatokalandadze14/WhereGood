using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Models
{
    public class Announcment : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public AppartmentTypeEnum Type { get; set; }
        public PropertyTypeEnum PropertyType { get; set; }

        public Guid? HouseOwnerId { get; set; }
        public Guid? PriceId { get; set; }
    }   
}