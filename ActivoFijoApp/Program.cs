using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interface;
using AppCore.Service;
using Autofac;
using Domain;
using Domain.Interfaces;
using Infraestructura;

namespace ActivoFijoApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ActivoModel>().As<IActivofijoModel>();
            builder.RegisterType<ActivoFijoService>().As<ActivoFijo>();
            var container = builder.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(container.Resolve<IActivoFijo>()));
        }
    }
}
