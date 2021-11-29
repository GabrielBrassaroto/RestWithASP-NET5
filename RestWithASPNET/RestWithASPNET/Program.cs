using Microsoft.EntityFrameworkCore;
using RestWithASPNET.Model.Context;
using RestWithASPNET.Business;
using RestWithASPNET.Business.Implementations;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using RestWithASPNET.Repository;
using RestWithASPNET.Repository.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
builder.Services.AddDbContext<MySqlContext>(options =>
{
    options.UseMySql(connection, ServerVersion.AutoDetect(connection));
});
//Versioning API
builder.Services.AddApiVersioning();
//injeção de depedencias 
builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();//Injeção de independencia
builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();//Injeção de independencia
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
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
