using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.DAC.Data;
using myper.DAC.IRepositories;

public class DepartamentoRepository : IDepartamentoRepository
{
    private readonly ApplicationDbContext _context;

    public DepartamentoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Departamento> GetAllDepartamentos()
    {
        return _context.Departamentos.ToList();
    }

    public Departamento GetDepartamentoById(int id)
    {
        return _context.Departamentos.Find(id);
    }

    public Departamento CreateDepartamento(DepartamentoRequestDto departamento)
    {
        var departamentoNuevo = new Departamento
        {
            NombreDepartamento = departamento.NombreDepartamento,
        };
        _context.Departamentos.Add(departamentoNuevo);
        _context.SaveChanges();
        return departamentoNuevo;
    }

    public Departamento UpdateDepartamento(int id, DepartamentoRequestDto departamento)
    {
        var departamentoActualizado = _context.Departamentos.FirstOrDefault(x => x.Id == id);
        departamentoActualizado.NombreDepartamento = departamento.NombreDepartamento;

        _context.Departamentos.Update(departamentoActualizado);
        _context.SaveChanges();

        return departamentoActualizado;
    }

    public void DeleteDepartamento(int id)
    {
        var departamento = _context.Departamentos.Find(id);
        if (departamento != null)
        {
            _context.Departamentos.Remove(departamento);
            _context.SaveChanges();
        }
    }
}

