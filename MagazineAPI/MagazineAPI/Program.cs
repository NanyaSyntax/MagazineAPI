using MagazineAPI.Application.Interfaces;
using MagazineAPI.Application.Service;
using MagazineAPI.Persistence;
using MagazineAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<MagazineDbContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IMagazineService, MagazineService>();
builder.Services.AddScoped<IMagazineRepository, MagazineRepository>();


builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
