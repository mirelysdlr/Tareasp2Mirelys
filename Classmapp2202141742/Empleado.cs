using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classmapp2202141742
{
    public class Empleado : Miembrosdelacomunidad
    {
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public double Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
    }
}
