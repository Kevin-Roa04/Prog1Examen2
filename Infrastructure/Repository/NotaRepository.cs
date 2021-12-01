using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class NotaRepository : IModel<Nota>
    {
        public List<Nota> notas;
        public NotaRepository()
        {
            notas = new List<Nota>();
        }
        public void Add(Nota t)
        {
            notas.Add(t);
        }

        public List<Nota> FindAll()
        {
            return notas;
        }

        public decimal CalculoPromedioNotas(List<Nota> Nota)
        {
            decimal a = Nota.Sum(x => x.NotaFinal);
            return a / 6;
        }
    }
}
