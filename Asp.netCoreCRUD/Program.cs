var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ToDo}/{action=Index}/{id?}");

app.Run();

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<MvcTaskContext>(options =>
    //options.UseSqlServer(builder.Configuration.GetConnectionString("MvcTaskContext")));
