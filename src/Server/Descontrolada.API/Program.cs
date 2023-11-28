using Descontrolada.API.Configuration;
using Descontrolada.API.Extensions;
using Descontrolada.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureHttpJsonOptions(opts =>  {
    opts.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});
builder.Services.AddCors(opts => {
    opts.AddPolicy(MyAllowSpecificOrigins, builder => 
    {
        builder.WithOrigins("http://localhost:5277")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});
builder.Services.RegisterServices();
builder.Services.AddDbContext<AppDbContext>(opts => opts.UseInMemoryDatabase("Descontrolada"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.MapProductsEndpoints();

Configuration.SeedDatabase(app!.Services.CreateScope());

app.Run();

