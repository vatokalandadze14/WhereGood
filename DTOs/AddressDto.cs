namespace HouseOwnerWebApi.DTOs
{
    //TODO: Make All dto parameters more readable.
    public record struct AddressDto(
        string? city, 
        string? municipality, 
        double longitude, 
        double latitute, 
        string? region, 
        string? district, 
        string street, 
        string? streetNumber, 
        Guid? AnnouncmentId, 
        Guid? AgencyId, 
        Guid? CompanyId
        );
}
