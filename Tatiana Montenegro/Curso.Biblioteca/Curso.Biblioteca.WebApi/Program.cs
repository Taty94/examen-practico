using Curso.Biblioteca.Aplicacion.Servicios;
using Curso.Biblioteca.Aplicacion.ServiciosImplementacion;
using Curso.Biblioteca.Dominio.Interfaces;
using Curso.Biblioteca.Infraestructura.Context;
using Curso.Biblioteca.Infraestructura.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//AGREGAR CONEXION A BDD
builder.Services.AddDbContext<BibliotecaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Biblioteca"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IAutorRepositorio, AutorRepositorio>();
builder.Services.AddTransient<IEditorialRepositorio, EditorialRepositorio>();
builder.Services.AddTransient<ILibroRepositorio, LibroRepositorio>();

builder.Services.AddTransient<IAutorServicio, AutorServicio>();
builder.Services.AddTransient<IEditorialServicio, EditorialServicio>();
builder.Services.AddTransient<ILibroServicio, LibroServicio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
