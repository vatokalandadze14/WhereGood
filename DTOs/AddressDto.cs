﻿namespace HouseOwnerWebApi.DTOs
{
    public record struct AddressDto(Guid id, string? city, string? municipality, double longitude, double latitute, string? region, string? district, string street, string? streetNumber, Guid? AnnouncmentId, Guid? AgencyId, Guid? CompanyId);
}
