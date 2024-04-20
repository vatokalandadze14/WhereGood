namespace HouseOwnerWebApi.DTOs
{
    public record struct AgencyDto(
        string Name,
        string Mail, 
        int PhoneNumber, 
        string? Site, 
        string Description, 
        Guid AddressId, 
        Guid SocialLinksId
        );
}
