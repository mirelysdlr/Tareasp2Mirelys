using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classmapp2202141742
{
    public class Administrativo : Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string CargoAdministrativo { get; set; }
        public string NivelAcceso { get; set; }
    }
}
