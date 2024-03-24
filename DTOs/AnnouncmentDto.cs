using HouseOwnerWebApi.Migrations;
using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.DTOs
{
    public record struct AnnouncmentDto(Guid Id,string title, string description, string shortDescription, AppartmentTypeEnum type, PropertyTypeEnum propertyType, Guid houseOwnerId);
}
    