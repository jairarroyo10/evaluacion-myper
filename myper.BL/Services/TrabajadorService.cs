using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.BL.IServices;
using myper.DAC.IRepositories;


namespace myper.BL.Services
{
    public class TrabajadorService : ITrabajadorService
    {
        private readonly ITrabajadorRepository _trabajadorRepository;

        public TrabajadorService(ITrabajadorRepository trabajadorRepository)
        {
            _trabajadorRepository = trabajadorRepository;
        }

        public IEnumerable<Trabajador> GetAllTrabajadores()
        {
            return _trabajadorRepository.GetAllTrabajadores();
        }

        public Trabajador GetTrabajadorById(int id)
        {
            return _trabajadorRepository.GetTrabajadorById(id);
        }

        public Trabajador CreateTrabajador(TrabajadorRequestDto trabajador)
        {
            return _trabajadorRepository.CreateTrabajador(trabajador);
        }

        public Trabajador UpdateTrabajador(int id, TrabajadorRequestDto trabajador)
        {
            return _trabajadorRepository.UpdateTrabajador(id, trabajador);
        }

        public void DeleteTrabajador(int id)
        {
            _trabajadorRepository.DeleteTrabajador(id);
        }
    }
}
