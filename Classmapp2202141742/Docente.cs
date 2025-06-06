using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classmapp2202141742
{
    public class Docente : Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Asignatura { get; set; }
        public string NivelAcademico { get; set; } 
        public int HorasClasePorSemana { get; set; }
    }
}
