using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.DTOs
{
    public record struct ImageCreateDto(Guid Id, string name, string url, Guid AnnouncmentId);

}
