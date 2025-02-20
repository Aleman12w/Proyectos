using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coche_2._1_2430744
{
    public class Cochefreno : Coche
    {
        public Cochefreno(string marca, string modelo, string velocidad_maxima, string velocidad_actual, int velocidad)
            : base(marca, modelo, velocidad_actual, velocidad_maxima, velocidad)
        {

        }

        public void Frenar(int freno)
        {
            Console.WriteLine("El carro acelera " + freno);
            this.Velocidad = Convert.ToInt32(freno = 0);
        }

    }
}
