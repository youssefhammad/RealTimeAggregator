using Google.Api;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MudBlazor.Services;
using RealTimeAggregator.Core;
using RealTimeAggregator.Data;
using RealTimeAggregator.Data.ProductsConfig;
using RealTimeAggregator.Data.Purchase;
using RealTimeAggregator.Data.Sales;
using RealTimeAggregator.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddMudServices();

builder.Services.AddDbContext<SalesDbContext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("SalesDatabase")));
builder.Services.AddDbContext<PurchaseDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PurchaseDatabase")));

// Configure Unit of Work
builder.Services.AddScoped<SalesUnitOfWork>();
builder.Services.AddScoped<PurchaseUnitOfWork>();

// Configure Services
builder.Services.AddScoped<ISalesService, SalesService>();
builder.Services.AddScoped<IPurchaseService, PurchaseService>();
        
builder.Services.Configure<ProductsConfigDbConfiguration>(builder.Configuration.GetSection("ProductsConfigDb"));
builder.Services.AddSingleton<IProductsConfigDbService, ProductsConfigDbService>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(CouchbaseRepository<>));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
