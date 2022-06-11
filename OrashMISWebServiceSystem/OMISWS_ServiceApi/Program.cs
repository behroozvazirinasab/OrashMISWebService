using OMISServiceHub;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration.GetConnectionString("OMISWSSDB");

//servicehub
builder.Services.AddServiceHubContainer(connection);


builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Index}/{action=Index}");

app.Run();
