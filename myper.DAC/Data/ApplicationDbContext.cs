using Microsoft.EntityFrameworkCore;
using myper.BE.Dtos.Response;
using myper.BE.Models;
using System.Data;

namespace myper.DAC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Trabajador> Trabajadores { get; set; }
    }
}