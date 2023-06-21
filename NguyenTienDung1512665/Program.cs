using Microsoft.EntityFrameworkCore;
using NguyenTienDung1512665.DbContexts;
using NguyenTienDung1512665.Entities;
using NguyenTienDung1512665.Services.Implements;
using NguyenTienDung1512665.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//NEW
builder.Services.AddDbContext<HangHoaContext1512665De2>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("HangHoaManagement")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//NEW
builder.Services.AddCors();
builder.Services.AddScoped<IHangHoaServices1512665De2, HangHoaServices1512665De2>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();