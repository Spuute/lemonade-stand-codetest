using Lemonade.Stand.Application.Interfaces.Repositories;
using Lemonade.Stand.Infrastructure;
using Lemonade.Stand.Infrastructure.Persistence;
using Lemonade.Stand.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddDbContext<ApplicationDbContext>(opts => opts.UseMySql(builder.Configuration.GetConnectionString("Db"), new MariaDbServerVersion(new System.Version(10, 5, 6))));
builder.Services.AddInfrastructure(builder.Configuration);


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
