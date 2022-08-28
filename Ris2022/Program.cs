using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Ris2022.Data;
using Ris2022.Data.Models;
using Ris2022.Interfaces;
using Ris2022.Repositories;
using Ris2022.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RisDBContext>(options => options.UseOracle(
    builder.Configuration.GetConnectionString("DefaultConnection")
));
#region
builder.Services.AddDefaultIdentity<RisAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<RisDBContext>()
    .AddDefaultUI();
builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
});
#endregion
builder.Services.AddControllersWithViews();

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("en-US");
 
    var cultures = new[] { "en-US", "fr", "ar" };
    options.SetDefaultCulture(cultures[0]);
    options.AddSupportedCultures(cultures);
    options.AddSupportedUICultures(cultures);
    options.DefaultRequestCulture = new RequestCulture("en-US");
});
// builder.Services.AddMvc().AddViewLocalization();
builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});
//builder.Services.AddLocalization();
builder.Services.AddSingleton<CommonLocalizationService>();
#region Repositories
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IPatientRepository, PatientRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// var localizationOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>().Value;
// app.UseRequestLocalization(localizationOptions);
	
app.UseRequestLocalization();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();
app.MapDefaultControllerRoute();
app.Run();
