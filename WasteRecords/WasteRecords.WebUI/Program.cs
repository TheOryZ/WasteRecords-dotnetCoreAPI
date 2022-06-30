using WasteRecords.WebUI.ApiServices.Interfaces;
using WasteRecords.WebUI.ApiServices.Services;
using WasteRecords.WebUI.RestAccess.Interfaces;
using WasteRecords.WebUI.RestAccess.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAccessRest, GenericRestAccess>();
builder.Services.AddScoped<IAuthApiService, AuthApiService>();

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
    pattern: "{controller=Home}/{action=SignIn}/{id?}");

app.Run();
