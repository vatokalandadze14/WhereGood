namespace HouseOwnerWebApi.Models.Share
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
