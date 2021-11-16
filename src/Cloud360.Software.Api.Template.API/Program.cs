using Cloud360.Software.Api.Template.Application;
using Cloud360.Software.Api.Template.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme);


builder.Services.AddApplication();
builder.Services.AddInfrastructure();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(opt => opt.DefaultModelsExpandDepth(-1));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
