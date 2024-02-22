using AdaTech.ClothStore.Data.Models;
using AdaTech.ClothStore.Data.Repository;
using AdaTech.ClothStore.Data.Repository.Interface;
using AdaTech.ClothStore.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<List<Item>>();
builder.Services.AddSingleton<IItemRepository, ItemRepositoryMemory>();
builder.Services.AddSingleton<IVendaRepository, VendaRepositoryMemory>();
builder.Services.AddSingleton<IRetornoRepository, RetornoRepositoryMemory>();
builder.Services.AddSingleton<ITrocaRepository, TrocaRepositoryMemory>();

builder.Services.AddScoped<ActionFilter>();

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ExceptionFilter>();
    options.Filters.Add<ActionFilter>();
});

builder.Services.AddCors(corsOptions =>
{
    corsOptions.AddPolicy("localhost", policyBuilder =>
    {
        policyBuilder.WithOrigins("http://localhost:5500");
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("localhost");
}

app.UseAuthorization();

app.MapControllers();

app.Run();