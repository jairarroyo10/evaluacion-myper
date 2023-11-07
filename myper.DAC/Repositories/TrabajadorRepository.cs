using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.DAC.Data;
using myper.DAC.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace myper.DAC.Repositories
{
    public class TrabajadorRepository : ITrabajadorRepository
    {
        private readonly ApplicationDbContext _context;

        public TrabajadorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Trabajador> GetAllTrabajadores()
        {
            var trabajadores = _context.Trabajadores.FromSqlRaw<Trabajador>("EXEC sp_GetTrabajadores").ToList();           

            return trabajadores;
        }
        public Trabajador GetTrabajadorById(int id)
        {
            return _context.Trabajadores.Find(id);
        }

        public Trabajador CreateTrabajador(TrabajadorRequestDto trabajador)
        {
            var trabajadorNuevo = new Trabajador
            {
                TipoDocumento = trabajador.TipoDocumento,
                NumeroDocumento = trabajador.NumeroDocumento,
                Nombres = trabajador.Nombres,
                Sexo = trabajador.Sexo,
                IdDepartamento = trabajador.IdDepartamento,
                IdProvincia = trabajador.IdProvincia,
                IdDistrito = trabajador.IdDistrito
                
            };
            _context.Trabajadores.Add(trabajadorNuevo);
            _context.SaveChanges();
            return trabajadorNuevo;
        }

        public Trabajador UpdateTrabajador(int id, TrabajadorRequestDto trabajador)
        {
            var trabajadorActualizado = _context.Trabajadores.FirstOrDefault(x => x.Id == id);
            trabajadorActualizado.TipoDocumento = trabajador.TipoDocumento;
            trabajadorActualizado.NumeroDocumento = trabajador.NumeroDocumento;
            trabajadorActualizado.Nombres = trabajador.Nombres;
            trabajadorActualizado.Sexo = trabajador.Sexo;
            trabajadorActualizado.IdDepartamento = trabajador.IdDepartamento;
            trabajadorActualizado.IdProvincia = trabajador.IdProvincia;
            trabajadorActualizado.IdDistrito = trabajador.IdDistrito;

            _context.Trabajadores.Update(trabajadorActualizado);
            _context.SaveChanges();

            return trabajadorActualizado;
        }

        public void DeleteTrabajador(int id)
        {
            var trabajador = _context.Trabajadores.Find(id);
            if (trabajador != null)
            {
                _context.Trabajadores.Remove(trabajador);
                _context.SaveChanges();
            }
        }
    }
}
