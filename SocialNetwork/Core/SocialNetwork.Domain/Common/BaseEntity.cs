namespace SocialNetwork.Domain.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedByName { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public string LastModifiedBy { get; set; }
}
