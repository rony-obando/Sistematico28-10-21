using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IActivofijoModel:IModel<ActivoFijo>
    {
        decimal[] SDA(ActivoFijo e);
        decimal[] linearecta(ActivoFijo e);
        int VidaUtil(TipoActivo e);
        string mostrar();
    }
}
