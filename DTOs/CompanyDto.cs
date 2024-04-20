namespace HouseOwnerWebApi.DTOs
{
    public record struct CompanyDto(
        string Name, 
        string Mail, 
        int PhoneNumber, 
        string? Site, 
        string Description
        );
}
