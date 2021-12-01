using AppCore.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Formulario
{
    public partial class Form1 : Form
    {
        private IService<Estudiante> ServiceEstudiante;
        private IService<Nota> ServiceNota;
        public Form1(IService<Estudiante> service, IService<Nota> services)
        {
            ServiceEstudiante = service;
            ServiceNota = services;
            InitializeComponent();
        }
    }
}
