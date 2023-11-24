using Ecomerce.DTO;
using Ecomerce.WebAssembly.Servicios.Contrato;
using System.Net.Http.Json;
using System.Text.Json;

namespace Ecomerce.WebAssembly.Servicios.Implementacion
{
    public class VentaServicio :IVentaServicio
    {

        private readonly HttpClient _httpClient;
        public VentaServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDTO<VentaDTO>> Registrar(VentaDTO modelo)
        {
            var response = await _httpClient.PostAsJsonAsync("Venta/Registrar", modelo);

            var result = await response.Content.ReadFromJsonAsync<ResponseDTO<VentaDTO>>();
            return result!;
         
        }
    }
}
