namespace HouseOwnerWebApi.DTOs
{
    public record struct PriceDto(
        int TotalGEL,
        int TotalUSD,
        int SquareMeterGEL,
        int SquareMeterUSD,
        Guid AnnouncmentId
        );
}
