namespace HouseOwnerWebApi.Models
{
    public class Agency
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int PhoneNumber { get; set; }
        public Adress? Adress { get; set; }
        public List<SocialLink> SocialLinks { get; set; }
    }
}
