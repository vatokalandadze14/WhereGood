namespace HouseOwnerWebApi.DTOs
{
    public record struct HouseOwnerDto(
        string name,
        string surName,
        int phoneNumber,
        bool agent, 
        Guid AnnouncmentId
        );
}
