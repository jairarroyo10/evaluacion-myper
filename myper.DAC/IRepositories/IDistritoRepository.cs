using myper.BE.Dtos.Request;
using myper.BE.Models;

namespace myper.DAC.IRepositories
{
    public interface IDistritoRepository
    {
        IEnumerable<Distrito> GetAllDistritos();
        Distrito GetDistritoById(int id);
        Distrito CreateDistrito(DistritoRequestDto distrito);
        Distrito UpdateDistrito(int id, DistritoRequestDto distrito);
        void DeleteDistrito(int id);
    }
}