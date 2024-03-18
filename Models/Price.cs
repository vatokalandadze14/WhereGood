using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Models
{
    public class Price : BaseEntity
    {
        public int TotalGEL { get; set; }
        public int TotalUSD { get; set; }
        public int SquareMeterGEL { get; set; }
        public int SquareMeterUSD { get; set; }
    }
}
