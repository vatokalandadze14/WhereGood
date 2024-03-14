namespace HouseOwnerWebApi.Models
{
    public class Announcment
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public Price Price { get; set; }
        public Adress Adress { get; set; }
        public List<Image> Images { get; set; }
        public AppartmentTypeEnum Type { get; set; }
        public PropertyTypeEnum PropertyType { get; set; }
        public HouseOwner HouseOwner { get; set; }
    }
}