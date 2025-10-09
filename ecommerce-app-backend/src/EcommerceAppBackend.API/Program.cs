using EcommerceAppBackend.API.Persistence.Database;
using EcommerceAppBackend.API.Persistence.Repositories;
using EcommerceAppBackend.API.RequestPipeline;
using EcommerceAppBackend.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddDbContext<EcommerceAppDbContext>(options =>
    {
        options.UseNpgsql(builder.Configuration["Database:ConnectionStrings:DefaultConnection"]);
    });
    builder.Services.AddScoped<DevicesService>();
    builder.Services.AddScoped<DevicesRepository>();
    builder.Services.AddOpenApi();
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.ApplyMigrations();
    app.MapControllers();
    app.UseHttpsRedirection();
    app.Run();
}