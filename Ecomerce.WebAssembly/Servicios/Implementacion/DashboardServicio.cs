using Ecomerce.DTO;
using Ecomerce.WebAssembly.Servicios.Contrato;
using System.Net.Http.Json;

namespace Ecomerce.WebAssembly.Servicios.Implementacion
{
    public class DashboardServicio :IDashboardServicio
    {

        private readonly HttpClient _httpClient;
        public DashboardServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDTO<DashboardDTO>> Resumen()
        {
            return await _httpClient.GetFromJsonAsync<ResponseDTO<DashboardDTO>>($"Dashboard/Resumen");
        }
    }
}
