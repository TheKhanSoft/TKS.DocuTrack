namespace TKS.DocuTrack.Entities
{
    public class UserExtended : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;

        [Phone, ProtectedPersonalData]
        public string? PhoneNumber2 { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = null;
        public DateTime? DeletedAt { get; set; } = null;

    }

}
