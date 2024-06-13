namespace TKS.DocuTrack.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    //public AppDbContext CreateDbContext(string[] args)
    //{
    //    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
    //    //var connectionName = "DBConnectionString";

    //    //var connectionString = System.Configuration.GetConnectionString(connectionName) ?? throw new InvalidOperationException("Connection string '" + connectionName + "' not found.");

    //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TKS.UMS;Trusted_Connection=True;MultipleActiveResultSets=true");

    //    return new AppDbContext(optionsBuilder.Options);
    //}

    public ApplicationDbContextFactory() { }

    public AppDbContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .Build();
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        var connectionString = builder.GetConnectionString("DBConnectionString");

        optionsBuilder.UseSqlServer(connectionString);

        return new AppDbContext(optionsBuilder.Options);
    }


}
