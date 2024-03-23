namespace HouseOwnerWebApi.DTOs
{
    public record struct HouseOwnerDto(Guid Id, string name, string surName, int phoneNumber, bool agent);
}
