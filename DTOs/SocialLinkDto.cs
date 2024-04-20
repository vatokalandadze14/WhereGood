using HouseOwnerWebApi.Models;

namespace HouseOwnerWebApi.DTOs
{
    public record struct SocialLinkDto(
        SocialEnum Type, 
        string Url, Guid 
        AgencyId, 
        Guid CompanyId
        );
}
