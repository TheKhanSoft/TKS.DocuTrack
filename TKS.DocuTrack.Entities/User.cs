namespace TKS.DocuTrack.Entities;

public class User : BaseEntity
{
    [Required]
    public string FullName { get; set; }

    [EmailAddress, Required]
    public string Email { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }

    [Phone, Required]
    public string ContactNo { get; set; }

    [Phone]
    public string AlternativeContactNo { get; set; } = string.Empty;



}
