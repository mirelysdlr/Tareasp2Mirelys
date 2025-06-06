using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classmapp2202141742
{
    public class Estudiante : Miembrosdelacomunidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }
        public double Promedio { get; set; }
        public List<string> MateriasInscritas { get; set; }
    }
}
