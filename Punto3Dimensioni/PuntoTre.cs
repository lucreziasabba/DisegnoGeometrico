using Punto2Dimensioni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3Dimensioni
{
    public class PuntoTre : PuntoDue
    {
        public double Z { get; set; }

        public PuntoTre(double x, double y, double z) : base(x, y)
        {
            Z = z; 
        }
    }
}
