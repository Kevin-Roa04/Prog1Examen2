using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class EstudianteService : IService<Estudiante>
    {
        private IModel<Estudiante> model;
        public EstudianteService(IModel<Estudiante> model)
        {
            this.model = model;
        }
        public void Add(Estudiante t)
        {
            model.Add(t);
        }

        public List<Estudiante> FindAll()
        {
            return model.FindAll();
        }
    }
}
