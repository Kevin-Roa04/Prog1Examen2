using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var builder = new ContainerBuilder();

            //builder.RegisterType<ObjetoRepository>().As<IObjetoRespository>();
            //builder.RegisterType<ObjetoService>().As<IObjetoService>();

            //var container = builder.build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Formulario(container.Resolve<IObjetoService>()));
        }
    }
}
