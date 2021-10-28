using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Interface;
using Domain;
using Domain.Interfaces;
using Infraestructura;

namespace AppCore.Service
{
    public class ActivoFijoService : IActivoFijo
    {
        private IActivofijoModel activo;
        public ActivoFijoService(ActivoModel a)
        {
            activo = a;
        }
        public void Create(ActivoFijo a)
        {
            activo.Create(a);
        }

        public ActivoFijo[] FindAll()
        {
           return activo.FindAll();
        }

        public decimal[] linearecta(ActivoFijo e)
        {
            return activo.linearecta(e);
        }

        public string mostrar()
        {
           return activo.mostrar();
        }

        public decimal[] SDA(ActivoFijo e)
        {
            return activo.SDA(e);
        }

        public int VidaUtil(TipoActivo e)
        {
            return activo.VidaUtil(e);
        }
    }
}
