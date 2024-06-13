using Microsoft.EntityFrameworkCore;
using TKS.DocuTrack.Data;

var builder = WebApplication.CreateBuilder(args);





// Add services to the container
var connectionName = "DBConnectionString";
var connectionString = builder.Configuration.GetConnectionString(connectionName) ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

//builder.Services.AddDbContextFactory<AppDbContext, DbContextFactory>(options =>

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddRazorPages();
//builder.Services.AddRazorPages().AddRazorPagesOptions(options =>
//{
//    options.Conventions.AddPageRoute("/Privacy", "/area/privacy");

//});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
