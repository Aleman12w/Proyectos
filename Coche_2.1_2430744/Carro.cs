using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coche_2._1_2430744
{
    public class Coche
    {
        public Coche(string marca, string modelo, string velocidad_maxima, string velocidad_actual, int velocidad)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Velocidad_maxima = velocidad_maxima;
            this.Velocidad_actual = velocidad_actual;
            this.Velocidad = velocidad;
        }

        public string Marca;
        public string Modelo;
        public string Velocidad_maxima;
        public string Velocidad_actual;
        public int Velocidad;

        public void acelera(int aceleracion)
        {
            Console.WriteLine("El carro acelera " + aceleracion);
            this.Velocidad = Convert.ToInt32(aceleracion + (5));
        }

        public void decelerar(int deceleracion)
        {
            Console.WriteLine("El carro decelera " + deceleracion);
            this.Velocidad = Convert.ToInt32(deceleracion+(-5));
        }
    }
}