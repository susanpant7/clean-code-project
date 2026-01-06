using CleanCodeProject.Api;
using CleanCodeProject.Application;
using CleanCodeProject.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.AddApiConfig(configuration);
services.AddApplicationConfig();
services.AddInfrastructureConfig(builder.Configuration);

var app = builder.Build();

app.UseApiConfiguration();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.Run();