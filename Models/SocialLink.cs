namespace HouseOwnerWebApi.Models
{
    public class SocialLink
    {
        public string Id { get; set; }
        public SocialEnum Type { get; set; }
        public string Url { get; set; }
        public Agency Agency { get; set; }
    }
}
