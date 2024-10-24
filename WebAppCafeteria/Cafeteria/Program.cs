using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cafeteria.Data;

using System.Globalization;
using Microsoft.AspNetCore.Localization;

// Definir a cultura para en-US (ponto como separador decimal)
var defaultCulture = new CultureInfo("en-US");
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(defaultCulture),
    SupportedCultures = new List<CultureInfo> { defaultCulture },
    SupportedUICultures = new List<CultureInfo> { defaultCulture }
};


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CafeteriaContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CafeteriaContext") ?? throw new InvalidOperationException("Connection string 'CafeteriaContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseRequestLocalization(localizationOptions);

app.Run();
