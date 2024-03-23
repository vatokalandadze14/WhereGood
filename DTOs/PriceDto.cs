namespace HouseOwnerWebApi.DTOs
{
    public record struct PriceDto(Guid Id, int TotalGEL, int TotalUSD, int SquareMeterGEL, int SquareMeterUSD, Guid AnnouncmentId);
}
