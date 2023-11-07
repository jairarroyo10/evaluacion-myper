using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.BL.IServices;
using myper.DAC.IRepositories;


namespace myper.BL.Services
{
    public class DistritoService : IDistritoService
    {
        private readonly IDistritoRepository _distritoRepository;

        public DistritoService(IDistritoRepository distritoRepository)
        {
            _distritoRepository = distritoRepository;
        }

        public IEnumerable<Distrito> GetAllDistritos()
        {
            return _distritoRepository.GetAllDistritos();
        }

        public Distrito GetDistritoById(int id)
        {
            return _distritoRepository.GetDistritoById(id);
        }

        public Distrito CreateDistrito(DistritoRequestDto distrito)
        {
            return _distritoRepository.CreateDistrito(distrito);
        }

        public Distrito UpdateDistrito(int id, DistritoRequestDto distrito)
        {
            return _distritoRepository.UpdateDistrito(id, distrito);
        }

        public void DeleteDistrito(int id)
        {
            _distritoRepository.DeleteDistrito(id);
        }
    }
}
