namespace TKS.DocuTrack.Entities;

public class BaseEntity
{
    [Key, Required]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; } = null;
    public DateTime? DeletedAt { get; set; } = null;
}
