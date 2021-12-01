using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Nota
    {
        public Estudiante Estudiante { get; set; }
        public Asignatura Asignatura { get; set; }
        public int Sistematico { get; set; }
        public int Parcial1 { get; set; }
        public int Parcial2 {get; set;}
        public int NotaFinal => Sistematico + Parcial1 + Parcial2;
    }
}
