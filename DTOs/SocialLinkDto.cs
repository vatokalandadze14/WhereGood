using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.DTOs
{
    public record struct SocialLinkDto(Guid Id, SocialEnum Type, string Url, Guid AgencyId);
}
