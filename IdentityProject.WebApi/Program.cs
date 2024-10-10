using IdentityProject.WebApi.Context;
using IdentityProject.WebApi.Repository.Abstracts;
using IdentityProject.WebApi.Repository.Concretes;
using IdentityProject.WebApi.Services.Abstracts;
using IdentityProject.WebApi.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<IUserRepository, EFUserRepository>();
builder.Services.AddScoped<IUserService, UserService>();


builder.Services.AddDbContext<MsSqlContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization(); // If you need authorization

app.MapControllers(); // Map controller endpoints


app.Run();

