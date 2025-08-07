﻿using Web.Extendes;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMapperApp();

// Configuracion de la base de datos
builder.Services.AddDb("PgAdmin", builder.Configuration);
//builder.Services.AddDb("PgAdminLog", builder.Configuration);

// Inyeccion de dependencias de los controladores
builder.Services.AddInject();
builder.Services.AddJwtConfig(builder.Configuration);
builder.Services.AddViewAuthApi();

//Agrega las validaciones genericas
builder.Services.AddHelpersValidation();
builder.Services.AddCustomCors(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        // Endpoint del JSON de Swagger
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API V1");

        // Esto colapsa todos los endpoints
        c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
    });
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
