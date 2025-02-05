using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Zust_Project_MVC.Buisnes.Abstract;
using Zust_Project_MVC.Buisnes.Concrete;
using Zust_Project_MVC.DataAcces.Abstracts;
using Zust_Project_MVC.DataAcces.Concrete;
using Zust_Project_MVC.Entity.Data;
using Zust_Project_MVC.Entity.Entities;

/////////////////////////////////////////////////////////
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUserDal, UserDal>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IImageService, ImageServices>();

var connection = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<ZustDbContext>(opt =>
{
    opt.UseSqlServer(connection, b => b.MigrationsAssembly("Zust_Project_MVC.WebUI"));
});


builder.Services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
    .AddEntityFrameworkStores<ZustDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddSignalR();
builder.Services.AddControllersWithViews();

//builder.Services.AddScoped<IUserServices, UserServices>();
/*builder.Services.AddScoped<IUserServices, UserServices>()*/
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//app.AddScoped<IUserServices, UserServices>();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
