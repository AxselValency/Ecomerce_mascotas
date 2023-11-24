using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using Ecomerce.Servicio.Contrato;
using Ecomerce.DTO;
using Ecomerce.Servicio.Implementacion;


namespace Ecomerce.APIN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardServicio _dashboardServicio;

        public DashboardController(IDashboardServicio dashboardServicio)
        {

            _dashboardServicio = dashboardServicio;

        }

        [HttpGet("Resumen")]
        public  IActionResult Resumen()
        {

            var response = new ResponseDTO<DashboardDTO>();

            try
            {


                response.EsCorrecto = true;
                response.Resultado =  _dashboardServicio.Resumen();

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
