using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.DTOs
{
    public record struct AnnouncmentDto(
        string title, 
        string description, 
        string shortDescription, 
        AppartmentTypeEnum type, 
        PropertyTypeEnum propertyType, 
        Guid houseOwnerId
        );
}
    