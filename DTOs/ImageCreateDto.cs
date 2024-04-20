using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.DTOs
{
    public record struct ImageCreateDto(
        string name,
        string url,
        Guid AnnouncmentId
        );
}
