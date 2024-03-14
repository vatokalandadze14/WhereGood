namespace HouseOwnerWebApi.Models
{
    public class Image
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Announcment Announcment { get; set; }
    }
}
