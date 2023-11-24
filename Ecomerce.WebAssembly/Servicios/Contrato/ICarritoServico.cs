using Ecomerce.DTO;


namespace Ecomerce.WebAssembly.Servicios.Contrato
{
    public interface ICarritoServico
    {

        event Action MostrarItems;

        int CantidadProductos();
        Task AgregarCarrito(CarritoDTO modelo);

        Task EliminarCarrito(int idProducto);
        Task<List<CarritoDTO>> DevolverCarrito();

        Task LimpiarCarrito();


    }
}
