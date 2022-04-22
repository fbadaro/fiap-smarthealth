using Fiap.Smarthealth.Api.Actions.AgenteSaudeEnpoint;
using Fiap.Smarthealth.Api.Actions.FamiliaEndpoint;
using Fiap.Smarthealth.Api.Actions.PostoSaudeEndpoint;
using Fiap.Smarthealth.Infrastructure.ApplicationConfiguration;
using Fiap.Smarthealth.Infrastructure.ApplicationServices;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.OpenApi.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

var builderInDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    options.SerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Smarthealth API",
        Description = "API de integração com o Smarthealth",
        TermsOfService = new Uri("https://smarthealth.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "smarthealth.com",
            Url = new Uri("https://smarthealth.com/contact")
        },        
    });
});

builder.Services.AddAutoMapperApplication(typeof(Program).Assembly);
builder.Services.AddDBContextApplication(IsDevelopment: builderInDevelopment);
builder.Services.AddServiceApplication();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

// API Endpoints
app.MapFamiliaEndpoint();
app.MapAgenteSaudeEndpoint();
app.MapPostoSaudeEndpoint();
app.Run();