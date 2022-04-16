using Fiap.Smarthealth.Api.Actions.FamiliaEndpoint;
using Fiap.Smarthealth.Infrastructure.ApplicationConfiguration;
using Fiap.Smarthealth.Infrastructure.ApplicationServices;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

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
            Name = "Example Contact",
            Url = new Uri("https://smarthealth.com/contact")
        },        
    });
});

builder.Services.AddAutoMapperApplication(typeof(Program).Assembly);
builder.Services.AddDBContextApplication();
builder.Services.AddServiceApplication();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// API Endpoints
app.MapFamiliaEndpoint();

app.Run();