namespace TKS.DocuTrack.Data;

public class DbContextFactory : IDbContextFactory<AppDbContext>
{
    private readonly IConfiguration _configuration;

    public DbContextFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public AppDbContext CreateDbContext()
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DBConnectionString"));

        return new AppDbContext(optionsBuilder.Options);

    }
}
