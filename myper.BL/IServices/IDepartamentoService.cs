using myper.BE.Dtos.Request;
using myper.BE.Models;

namespace myper.BL.IServices
{
    public interface IDepartamentoService
    {
        IEnumerable<Departamento> GetAllDepartamentos();
        Departamento GetDepartamentoById(int id);
        Departamento CreateDepartamento(DepartamentoRequestDto departamento);
        Departamento UpdateDepartamento(int id, DepartamentoRequestDto departamento);
        void DeleteDepartamento(int id);
    }
}
