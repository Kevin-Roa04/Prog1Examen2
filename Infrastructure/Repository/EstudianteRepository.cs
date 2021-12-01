using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class EstudianteRepository : IModel<Estudiante>
    {
        public List<Estudiante> estudiantes;
        public EstudianteRepository()
        {
            estudiantes = new List<Estudiante>();
        }
        public void Add(Estudiante t)
        {
            estudiantes.Add(t);
        }

        public List<Estudiante> FindAll()
        {
            return estudiantes;
        }
    }
}
