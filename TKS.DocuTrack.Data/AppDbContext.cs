namespace TKS.DocuTrack.Data;
public class AppDbContext : IdentityDbContext<UserExtended>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<UserExtended>(entity =>
        {
            entity.ToTable(name: "Users");
        });

        builder.Entity<IdentityRole>(entity =>
        {
            entity.ToTable(name: "Roles");
        });
        builder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.ToTable("UserRoles");
            //  in case the TKey type has been changed enable the following
            //  entity.HasKey(key => new { key.UserId, key.RoleId });
        });

        builder.Entity<IdentityUserClaim<string>>(entity =>
        {
            entity.ToTable("UserClaims");
        });

        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.ToTable("UserLogins");
            //  in case the TKey type has been changed enable the following
            //  entity.HasKey(key => new { key.ProviderKey, key.LoginProvider });       
        });

        builder.Entity<IdentityRoleClaim<string>>(entity =>
        {
            entity.ToTable("RoleClaims");

        });

        builder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.ToTable("UserTokens");
            //  in case the TKey type has been changed enable the following
            //  entity.HasKey(key => new { key.UserId, key.LoginProvider, key.Name });

        });

        //new CampusSeeder(this).SeedAsync().Wait();
        //new OfficeTypeSeeder(this).SeedAsync().Wait();
        //Seed();
    }

    //----------------------------------------------------------

    public DbSet<Letter> Letters { get; set; }
    #region SETTINGS DbSets

    //public DbSet<OfficeType> OfficeTypes { get; set; }
    //public DbSet<JobNature> JobNatures { get; set; }
    //public DbSet<EmploymentStatus> EmploymentStatuses { get; set; }
    //public DbSet<DesignationType> DesignationTypes { get; set; }
    //public DbSet<Designation> Designations { get; set; }

    //#endregion

    ////----------------------------------------------------------

    //#region University related DbSets
    //public DbSet<Campus> Campuses { get; set; }
    //public DbSet<Faculty> Faculties { get; set; }
    //public DbSet<Office> Offices { get; set; }

    #endregion

}
