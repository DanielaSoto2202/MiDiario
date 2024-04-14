﻿using Microsoft.OpenApi.Models;
using ITD.MiDiario.Application;
using ITD.MiDiario.Infrastructure;
using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;



var builder = WebApplication.CreateBuilder(args);


var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");


if (string.IsNullOrEmpty(environment))
{
    throw new ArgumentException("La variable de entorno ASPNETCORE_ENVIRONMENT no está configurada.");
}
builder.Configuration.AddJsonFile($"appsettings.{environment}.json");


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSwaggerGen(options =>
{

    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Simulación de Diario Personal",
        Contact = new OpenApiContact
        {
            Name = "Daniela Guadalupe Soto Rodriguez",
            Email = "daniela_sr_22@outlook.com"
        },
        Description = $"API en ambiente {environment}."
    });


    options.AddSecurityDefinition("Basic", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.Http,
        Scheme = "basic",
        Description = "Requiere autenticación básica.",
        In = ParameterLocation.Header
    });
});


builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddApplication(builder.Configuration);




builder.Services.AddCors();


var app = builder.Build();

}

