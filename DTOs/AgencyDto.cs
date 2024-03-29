namespace HouseOwnerWebApi.DTOs
{
    public record struct AgencyDto(Guid Id, string Name, string Mail, int PhoneNumber, string? Site, string Description);
}
