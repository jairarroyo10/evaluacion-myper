using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.BL.IServices;
using myper.DAC.IRepositories;

namespace myper.BL.Services
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoService(IDepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

        public IEnumerable<Departamento> GetAllDepartamentos()
        {
            return _departamentoRepository.GetAllDepartamentos();
        }

        public Departamento GetDepartamentoById(int id)
        {
            return _departamentoRepository.GetDepartamentoById(id);
        }

        public Departamento CreateDepartamento(DepartamentoRequestDto departamento)
        {
            return _departamentoRepository.CreateDepartamento(departamento);
        }

        public Departamento UpdateDepartamento(int id, DepartamentoRequestDto departamento)
        {
            return _departamentoRepository.UpdateDepartamento(id, departamento);
        }

        public void DeleteDepartamento(int id)
        {
            _departamentoRepository.DeleteDepartamento(id);
        }

    }
}


