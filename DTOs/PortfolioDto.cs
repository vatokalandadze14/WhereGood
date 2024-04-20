namespace HouseOwnerWebApi.DTOs
{
    public record struct PortfolioDto(
        string Title,
        string HtmlDescription,
        Guid InterierCompanyId
    );
}
