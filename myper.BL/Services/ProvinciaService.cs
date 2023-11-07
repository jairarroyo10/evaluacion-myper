using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.BL.IServices;
using myper.DAC.IRepositories;
namespace myper.BL.Services
{
    public class ProvinciaService : IProvinciaService
    {
        private readonly IProvinciaRepository _provinciaRepository;

        public ProvinciaService(IProvinciaRepository provinciaRepository)
        {
            _provinciaRepository = provinciaRepository;
        }

        public IEnumerable<Provincia> GetAllProvincias()
        {
            return _provinciaRepository.GetAllProvincias();
        }

        public Provincia GetProvinciaById(int id)
        {
            return _provinciaRepository.GetProvinciaById(id);
        }

        public Provincia CreateProvincia(ProvinciaRequestDto provincia)
        {
            return _provinciaRepository.CreateProvincia(provincia);
        }

        public Provincia UpdateProvincia(int id, ProvinciaRequestDto provincia)
        {
            return _provinciaRepository.UpdateProvincia(id, provincia);
        }

        public void DeleteProvincia(int id)
        {
            _provinciaRepository.DeleteProvincia(id);
        }
    }
}   