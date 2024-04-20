namespace HouseOwnerWebApi.DTOs
{
    public record struct InterierCompanyDto(
        string Name,
        string Mail,
        int PhoneNumber,
        string? Site,
        string Description,
        Guid PortfolioId,
        Guid AddressId,
        Guid SocialLinkId
        );
}
