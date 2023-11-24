using Ecomerce.DTO;




namespace Ecomerce.WebAssembly.Servicios.Contrato
{
    public interface IVentaServicio
    {

        
        Task<ResponseDTO<VentaDTO>> Registrar(VentaDTO modelo);
      

    }
}
