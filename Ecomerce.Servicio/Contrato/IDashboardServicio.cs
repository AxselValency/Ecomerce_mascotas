using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecomerce.DTO;

namespace Ecomerce.Servicio.Contrato
{
   public interface IDashboardServicio
    {

        DashboardDTO Resumen();
    }
}
