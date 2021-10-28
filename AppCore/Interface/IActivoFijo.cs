using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interface
{
    public interface IActivoFijo:IService<ActivoFijo>
    {
        decimal[] SDA(ActivoFijo e);
        decimal[] linearecta(ActivoFijo e);
        int VidaUtil(TipoActivo e);
        string mostrar();
    }
}
