using Microsoft.EntityFrameworkCore;
using SchoolProject.Core;
using SchoolProject.Infrastructure;
using SchoolProject.Infrastructure.Data;
using SchoolProject.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



// Connection to DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolSystem"));
});

#region Dependency Injuction container
builder.Services
.AddInfrastructureDependencies()
.AddServicesDependencies()
.AddCoreDependencies(); 
#endregion

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
