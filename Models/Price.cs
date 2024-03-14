namespace HouseOwnerWebApi.Models
{
    public class Price
    {
        public string Id { get; set; }
        public int TotalGEL { get; set; }
        public int TotalUSD { get; set; }
        public int SquareMeterGEL { get; set; }
        public int SquareMeterUSD { get; set; }
    }
}
