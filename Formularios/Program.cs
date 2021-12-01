using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using Domain.Entities;
using Domain.Interfaces;
using Formularios.Formulario;
using Infrastructure.Repository;
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
            var builder = new ContainerBuilder();

            builder.RegisterType<EstudianteRepository>().As<IModel<Estudiante>>();
            builder.RegisterType<EstudianteService>().As<IService<Estudiante>>();

            builder.RegisterType<NotaRepository>().As<IModel<Nota>>();
            builder.RegisterType<NotaService>().As<IService<Nota>>();

            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(container.Resolve<IService<Estudiante>>(), container.Resolve<IService<Nota>>()));
        }
    }
}
