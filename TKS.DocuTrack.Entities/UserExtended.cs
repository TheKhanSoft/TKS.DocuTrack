namespace TKS.DocuTrack.Entities
{
    public class UserExtended : IdentityUser
    {
        public required string FullName { get; set; }

    }

}
