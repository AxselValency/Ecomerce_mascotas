using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecomerce.DTO;

namespace Ecomerce.Servicio.Contrato
{
    public interface IProductoServicio
    {

        Task<List<ProductoDTO>> Lista(string buscar);
        Task<List<ProductoDTO>> Catalogo(string buscar ,string categoria);

        Task<ProductoDTO> Obtener(int id);



        Task<ProductoDTO> Crear(ProductoDTO modelo);



        Task<bool> Editar(ProductoDTO modelo);


        Task<bool> Eliminar(int id);
    }


}

