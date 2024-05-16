global using loans_api.Interfaces;
global using loans_api.Services;
global using loans_api.Models;
global using Microsoft.OpenApi.Models;
global using Microsoft.AspNetCore.Mvc;
global using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "loans-api",
        Version = "v1",
        Description = "An API to perform person operations",
        Contact = new OpenApiContact
        {
            Name = "vilarj",
            Email = "vilarj@x.com",
            Url = new Uri("https://x.com/vilarjimenez"),
        },
        License = new OpenApiLicense
        {
            Name = "loans-api",
            Url = new Uri("https://example.com/license"),
        },

    });
});
builder.Services.AddScoped<IPerson, PersonService>();

// App
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();