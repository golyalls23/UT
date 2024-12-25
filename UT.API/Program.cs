using Microsoft.EntityFrameworkCore;
using UT.API.Services;
using UT.Domain.Models;
using UT.Repos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AdventureWorks2022Context>(
    options => options.UseSqlServer(
                    builder.Configuration["ConnectionStrings:AdventureWorksDBConnectionString"]
));

builder.Services.AddSingleton<IStudentsService, StudentsService>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
