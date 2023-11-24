using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using Ecomerce.Servicio.Contrato;
using Ecomerce.DTO;
using Ecomerce.Servicio.Implementacion;

namespace Ecomerce.APIN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {

        private readonly IVentaServicio _ventaServicio;

        public VentaController(IVentaServicio ventaServicio)
        {

            _ventaServicio = ventaServicio;

        }
        [HttpPost("Registrar")]
        public async Task<IActionResult> Registrar([FromBody] VentaDTO modelo)
        {

            var response = new ResponseDTO<VentaDTO>();

            try
            {


                response.EsCorrecto = true;
                response.Resultado = await _ventaServicio.Registrar(modelo);

            }


            catch (Exception EX)
            {

                response.EsCorrecto = false;
                response.Mensaje = EX.Message;
            }
            return Ok(response);

        }






    }
}
