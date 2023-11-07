using myper.BL.IServices;
using myper.BL.Services;
using myper.DAC.Data;
using myper.DAC.IRepositories;
using myper.DAC.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IDepartamentoRepository, DepartamentoRepository>();
builder.Services.AddTransient<IDepartamentoService, DepartamentoService>();
builder.Services.AddTransient<IDistritoRepository, DistritoRepository>();
builder.Services.AddTransient<IDistritoService, DistritoService>();
builder.Services.AddTransient<IProvinciaRepository, ProvinciaRepository>();
builder.Services.AddTransient<IProvinciaService, ProvinciaService>();
builder.Services.AddTransient<ITrabajadorRepository, TrabajadorRepository>();
builder.Services.AddTransient<ITrabajadorService, TrabajadorService>();

builder.Services.AddDbContext<ApplicationDbContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("TrabajadoresPrueba")));

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
