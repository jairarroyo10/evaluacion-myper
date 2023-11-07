using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.DAC.Data;
using myper.DAC.IRepositories;
namespace myper.DAC.Repositories
{
    public class ProvinciaRepository : IProvinciaRepository
    {
        private readonly ApplicationDbContext _context;

        public ProvinciaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Provincia> GetAllProvincias()
        {
            return _context.Provincias.ToList();
        }

        public Provincia GetProvinciaById(int id)
        {
            return _context.Provincias.Find(id);
        }

        public Provincia CreateProvincia(ProvinciaRequestDto provincia)
        {
            var provinciaNueva = new Provincia
            {
                IdDepartamento = provincia.IdDepartamento,
                NombreProvincia = provincia.NombreProvincia,
            };
            _context.Provincias.Add(provinciaNueva);
            _context.SaveChanges();
            return provinciaNueva;
        }

        public Provincia UpdateProvincia(int id, ProvinciaRequestDto provincia)
        {
            var provinciaActualizada = _context.Provincias.FirstOrDefault(x => x.Id == id);
            provinciaActualizada.IdDepartamento = provincia.IdDepartamento;
            provinciaActualizada.NombreProvincia = provincia.NombreProvincia;


            _context.Provincias.Update(provinciaActualizada);
            _context.SaveChanges();

            return provinciaActualizada;
        }

        public void DeleteProvincia(int id)
        {
            var provincia = _context.Provincias.Find(id);
            if (provincia != null)
            {
                _context.Provincias.Remove(provincia);
                _context.SaveChanges();
            }
        }
    }
}
    
