namespace HouseOwnerWebApi.DTOs
{
    public record struct PortfolioDto(Guid Id, string Title, string HtmlDescription, Guid InterierCompanyId);
}
