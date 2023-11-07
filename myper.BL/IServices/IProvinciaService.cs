using myper.BE.Dtos.Request;
using myper.BE.Models;
namespace myper.BL.IServices
{
    public interface IProvinciaService
    {
        IEnumerable<Provincia> GetAllProvincias();
        Provincia GetProvinciaById(int id);
        Provincia CreateProvincia(ProvinciaRequestDto provincia);
        Provincia UpdateProvincia(int id, ProvinciaRequestDto provincia);
        void DeleteProvincia(int id);
    }
}

