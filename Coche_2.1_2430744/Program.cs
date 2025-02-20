using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coche_2._1_2430744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche("Chevrolet", "Aveo", "60km/h", "150km/h", 0);
            Console.WriteLine("Descripcion del Coche:");
            Console.WriteLine("Marca:" + coche.Marca);
            Console.WriteLine("Modelo:" + coche.Modelo);
            Console.WriteLine("Velocidad actual:" + coche.Velocidad_actual);
            Console.WriteLine("Velocidad maxima:" + coche.Velocidad_maxima);

            coche.acelera(10);
            Console.WriteLine("El coche acelera:" + coche.Velocidad);
            coche.decelerar(10);
            Console.WriteLine("El coche decelera:" + coche.Velocidad);


            Cochefreno cochefreno = new Cochefreno("Chevrolet", "Aveo", "60km/h", "150km/h", 0);
            Console.WriteLine("Descripcion del Coche:");
            Console.WriteLine("Marca:" + coche.Marca);
            Console.WriteLine("Modelo:" + coche.Modelo);
            Console.WriteLine("Velocidad actual:" + coche.Velocidad_actual);
            Console.WriteLine("Velocidad maxima:" + coche.Velocidad_maxima);

            coche.acelera(10);
            Console.WriteLine("El coche acelera:" + coche.Velocidad);
            coche.decelerar(10);
            Console.WriteLine("El coche decelera:" + coche.Velocidad);
            cochefreno.Frenar(0);
            Console.WriteLine("El coche frena:" + coche.Velocidad);

            Console.ReadKey();
        }
    }
}
