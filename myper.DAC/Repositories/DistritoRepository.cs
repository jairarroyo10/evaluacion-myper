using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.DAC.Data;
using myper.DAC.IRepositories;

namespace myper.DAC.Repositories
{
    public class DistritoRepository : IDistritoRepository
    {
        private readonly ApplicationDbContext _context;

        public DistritoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Distrito> GetAllDistritos()
        {
            return _context.Distritos.ToList();
        }

        public Distrito GetDistritoById(int id)
        {
            return _context.Distritos.Find(id);
        }

        public Distrito CreateDistrito(DistritoRequestDto distrito)
        {
            var distritoNuevo = new Distrito
            {
                IdProvincia = distrito.IdProvincia,
                NombreDistrito = distrito.NombreDistrito,
            };
            _context.Distritos.Add(distritoNuevo);
            _context.SaveChanges();
            return distritoNuevo;
        }

        public Distrito UpdateDistrito(int id, DistritoRequestDto distrito)
        {
            var distritoActualizado = _context.Distritos.FirstOrDefault(x => x.Id == id);
            distritoActualizado.IdProvincia = distrito.IdProvincia;
            distritoActualizado.NombreDistrito = distrito.NombreDistrito;
           

            _context.Distritos.Update(distritoActualizado);
            _context.SaveChanges();

            return distritoActualizado;
        }

        public void DeleteDistrito(int id)
        {
            var distrito = _context.Distritos.Find(id);
            if (distrito != null)
            {
                _context.Distritos.Remove(distrito);
                _context.SaveChanges();
            }
        }
    }
}

