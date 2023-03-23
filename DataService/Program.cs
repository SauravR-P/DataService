using DataService.CQRS.Handlers;
using DataService.CQRS.Query;
using DataService.CQRS.Repository;
using DataService.CQRS.Service;
using DataService.Model;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;  //no underlines and imported via Nuget
using System.Reflection;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IGetAllRecords, GetAllRecords>();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddTransient<IRequestHandler<GetAllRecordsQuery, IReadOnlyList<Employee>>, GetAllRecordsQueryHandler>();
//builder.Services.AddMediatR(typeof(GetAllRecords).GetTypeInfo().Assembly);
//builder.Services.AddMediatR(typeof(GetAllRecordsQuery).GetTypeInfo().Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DemoDB")));

    

    var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
