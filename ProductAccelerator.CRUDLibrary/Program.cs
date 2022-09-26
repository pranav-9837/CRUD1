using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using ProductAccelerator.CRUDLibrary.Domain.Entities;
using ProductAccelerator.CRUDLibrary.Infrastructure.Context;
using ProductAccelerator.CRUDLibrary.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IUnitofWork, UnitofWork>();
//builder.Services.AddScoped<IBaseRepository<DemoEntity>, BaseRepository<DemoEntity>>();
//builder.Services.AddScoped<IBaseRepository<EmployeeEntity>, BaseRepository<EmployeeEntity>>();
builder.Services.AddDbContext<DemoContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefConn")));
builder.Services.AddDbContext<EmployeeContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefConn")));
//builder.Services.AddDbContext<BaseDataContext>(options =>
//options.UseSqlServer( builder.Configuration.GetConnectionString("DefConn")));

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
