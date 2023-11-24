using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Ecomerce.Servicio.Contrato;
using Ecomerce.DTO;
using Ecomerce.Servicio.Implementacion;

namespace Ecomerce.APIN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly ICategoriaServicio _categoriaServicio;

        public CategoriaController(ICategoriaServicio categoriaServicio)
        {

            _categoriaServicio = categoriaServicio;

        }


        [HttpGet("Lista/{buscar?}")]
        public async Task<IActionResult> Lista(string buscar = "NA")
        {

            var response = new ResponseDTO<List<CategoriaDTO>>();

            try
            {

                if (buscar == "NA") buscar = "";
                response.EsCorrecto = true;
                response.Resultado = await _categoriaServicio.Lista(buscar);

            }


            catch (Exception EX)
            {

                response.EsCorrecto = false;
                response.Mensaje = EX.Message;
            }
            return Ok(response);

        }

        [HttpGet("Obtener/{Id:int}")]
        public async Task<IActionResult> Obtener(int Id)
        {

            var response = new ResponseDTO<CategoriaDTO>();

            try
            {

              
                response.EsCorrecto = true;
                response.Resultado = await _categoriaServicio.Obtener(Id);

            }


            catch (Exception EX)
            {

                response.EsCorrecto = false;
                response.Mensaje = EX.Message;
            }
            return Ok(response);

        }


        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody]CategoriaDTO modelo)
        {

            var response = new ResponseDTO<CategoriaDTO>();

            try
            {


                response.EsCorrecto = true;
                response.Resultado = await _categoriaServicio.Crear(modelo);

            }


            catch (Exception EX)
            {

                response.EsCorrecto = false;
                response.Mensaje = EX.Message;
            }
            return Ok(response);

        }

        [HttpPut("Editar")]
        public async Task<IActionResult> Editar([FromBody] CategoriaDTO modelo)
        {

            var response = new ResponseDTO<bool>();

            try
            {


                response.EsCorrecto = true;
                response.Resultado = await _categoriaServicio.Editar(modelo);

            }


            catch (Exception EX)
            {

                response.EsCorrecto = false;
                response.Mensaje = EX.Message;
            }
            return Ok(response);

        }


        [HttpDelete("Eliminar/{Id:int}")]
        public async Task<IActionResult> Eliminar(int Id)
        {

            var response = new ResponseDTO<bool>();

            try
            {


                response.EsCorrecto = true;
                response.Resultado = await _categoriaServicio.Eliminar(Id);

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
