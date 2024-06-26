﻿using HouseOwnerWebApi.Models.Share;

namespace HouseOwnerWebApi.Models
{
    public class Agency : BaseEntity
    {
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public int PhoneNumber { get; set; }

        public Address? Address { get; set; }

        public Guid AddressId { get; set; }

        public ICollection<SocialLink>? SocialLinks { get; set; }
        public Guid SocialLinksId { get; set; }
        public string? Site { get; set; }
        public string? Description { get; set; }
    }
}
