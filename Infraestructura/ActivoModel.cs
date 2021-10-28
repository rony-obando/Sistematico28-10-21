using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Interfaces;

namespace Infraestructura
{
    public class ActivoModel:IActivofijoModel
    {
        ActivoFijo[] activo;
        public void Add(ActivoFijo a)
        {
            if (activo == null)
            {
                activo = new ActivoFijo[1];
                activo[0] = a;

            }
            else
            {
                ActivoFijo[] tmp = new ActivoFijo[activo.Length + 1];
                Array.Copy(activo, tmp, activo.Length);
                tmp[tmp.Length - 1] = a;
                activo = tmp;
            }

        }
        public string mostrar()
        {
            string mostrar = "";
            decimal[] b;
            int i = 0;
            if (activo != null)
            {
                foreach (ActivoFijo a in activo)
                {
                    if (a.metodoDepreciacion==MetodoDepreciacion.LineaRecta) {
                        b = linearecta(a);
                        mostrar = $@"ID {a.ID}{Environment.NewLine} Codigo {a.Codigo}{Environment.NewLine} Nombre {a.Nombre}{Environment.NewLine} descripcion {a.Descripcion}{Environment.NewLine} valor del activo {a.ValorActivo}{Environment.NewLine}
valor residual {a.ValorReesidual}{Environment.NewLine} vida util {a.VidaUtil}{Environment.NewLine} Fecha de aquisicion {a.FechaAdquicision}{Environment.NewLine} TipoActivo {a.TipoActivo}{Environment.NewLine} Meto de depresiacion {a.metodoDepreciacion}{Environment.NewLine}{Environment.NewLine}" + mostrar;
                        mostrar = $"año{i+1} Depresiacion{b[i]}";
                    }
                    else
                    {
                        b = SDA(a);
                        mostrar = $@"ID {a.ID}{Environment.NewLine} Codigo {a.Codigo}{Environment.NewLine} Nombre {a.Nombre}{Environment.NewLine} descripcion {a.Descripcion}{Environment.NewLine} valor del activo {a.ValorActivo}{Environment.NewLine}
valor residual {a.ValorReesidual}{Environment.NewLine} vida util {a.VidaUtil}{Environment.NewLine} Fecha de aquisicion {a.FechaAdquicision}{Environment.NewLine} TipoActivo {a.TipoActivo}{Environment.NewLine} Meto de depresiacion {a.metodoDepreciacion}{Environment.NewLine}{Environment.NewLine}" + mostrar;
                        mostrar = $"año{i + 1} Depresiacion{b[i]}";
                    }
                    i++;
                }
            }
            return mostrar;
        }
        public decimal[] SDA(ActivoFijo e)
        {
            int Suma = 0;
            decimal[] depreciacion = new decimal[e.VidaUtil];

            for (int i = 1; i <= e.VidaUtil; i++)
            {
                Suma += i;
            }
            for (int i = 0; i < e.VidaUtil; i++)
            {
                decimal a = (i + 1) * (e.ValorActivo - e.ValorReesidual);

                decimal total = a / Suma;

                depreciacion[i] = total;
            }
            return depreciacion;
        }
        public decimal[] linearecta(ActivoFijo e)
        {
            decimal[] LineaRecta = new decimal[e.VidaUtil];
            for (int i = 0; i < e.VidaUtil; i++)
            {
                decimal a = (e.ValorActivo - e.ValorReesidual) / e.VidaUtil;
                LineaRecta[i] = a;
            }
            return LineaRecta;

        }
        public int VidaUtil(TipoActivo e)
        {
            int i = 0;
            if (e == TipoActivo.Edificio)
            {
                i = 20;

            }
            else if (e == TipoActivo.Vehiculo)
            {
                i = 5;
            }
            else if (e == TipoActivo.Maquinaria)
            {
                i = 3;

            }
            else if (e == TipoActivo.Mobiliario)
            {
                i = 2;
            }
            else if (e == TipoActivo.EquipoComputo)
            {
                i = 1;
            }
            return i;
        }
        public ActivoFijo[] FindAll()
        {
            return activo;
        }

        public void Create(ActivoFijo t)
        {
            if (activo == null)
            {
                activo = new ActivoFijo[1];
                activo[0] = t;

            }
            else
            {
                ActivoFijo[] tmp = new ActivoFijo[activo.Length + 1];
                Array.Copy(activo, tmp, activo.Length);
                tmp[tmp.Length - 1] = t;
                activo = tmp;
            }
        }
    }
}
