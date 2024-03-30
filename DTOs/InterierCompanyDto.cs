namespace HouseOwnerWebApi.DTOs
{
    public record struct InterierCompanyDto(Guid Id, string Name, string Mail, int PhoneNumber, string? Site, string Description);
}
