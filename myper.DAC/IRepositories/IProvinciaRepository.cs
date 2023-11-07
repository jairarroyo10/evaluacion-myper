using myper.BE.Dtos.Request;
using myper.BE.Models;

namespace myper.DAC.IRepositories
{
    public interface IProvinciaRepository
    {
        IEnumerable<Provincia> GetAllProvincias();
        Provincia GetProvinciaById(int id);
        Provincia CreateProvincia(ProvinciaRequestDto provincia);
        Provincia UpdateProvincia(int id, ProvinciaRequestDto provincia);
        void DeleteProvincia(int id);
    }
}