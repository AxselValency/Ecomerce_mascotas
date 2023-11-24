using Ecomerce.DTO;

namespace Ecomerce.WebAssembly.Servicios.Contrato
{
    public interface IDashboardServicio
    {

        Task<ResponseDTO<DashboardDTO>> Resumen();
    }
}
