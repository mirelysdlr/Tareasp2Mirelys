using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classmapp2202141742
{
    internal class Exalumno : Miembrosdelacomunidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int AñoEgreso { get; set; }
        public string TituloObtenido { get; set; }
        public string EmpresaActual { get; set; }
        public string CargoActual { get; set; }
    }
}
