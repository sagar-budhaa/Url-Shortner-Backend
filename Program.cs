using System.Text;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Url_Shortner_Backend.Data;
using Url_Shortner_Backend.Middleware;
using Url_Shortner_Backend.Service.lib;
using Url_Shortner_Backend.Service.Url;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, serverVersion: ServerVersion.AutoDetect(connectionString)));


builder.Services.AddScoped<IUrlService, UrlService>();
builder.Services.AddScoped<IShortUrlGenerator, ShortUriGenerator>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseMiddleware<GlobalExceptionHandler>();

app.UseAuthorization();

app.MapControllers();

app.Run();