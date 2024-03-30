namespace HouseOwnerWebApi.DTOs
{
    public record struct CompanyDto(Guid Id, string Name, string Mail, int PhoneNumber, string? Site, string Description);
}
