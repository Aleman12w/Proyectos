using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_2430744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona Personal = new Persona("Verdes", "187", "85", "V");
            Console.WriteLine("Descripción de la persona: ");
            Console.WriteLine("Ojos:" + Personal.Ojos);
            Console.WriteLine("Altura:" + Personal.Altura);
            Console.WriteLine("Peso:" + Personal.Peso);
            Console.WriteLine("Sexo:" + Personal.Sexo);

            Personal.Hablar("Me llamo Borja");
            Console.WriteLine("Color de mis ojos:" + Personal.Ojos);
            Personal.correr(1000);
            Console.WriteLine("Mi peso actual es:" + Personal.Peso);
            
            PersonaNadadora Personal2 = new PersonaNadadora("Verdes", "187", "85", "V");
            Console.WriteLine("Descripción de la persona: ");
            Console.WriteLine("Ojos:" + Personal.Ojos);
            Console.WriteLine("Altura:" + Personal.Altura);
            Console.WriteLine("Peso:" + Personal.Peso);
            Console.WriteLine("Sexo:" + Personal.Sexo);

            Personal.Hablar("Me llamo Borja");
            Console.WriteLine("Color de mis ojos:" + Personal.Ojos);
            Personal.correr(1000);
            Console.WriteLine("Mi peso actual es:" + Personal.Peso);
            Personal2.Nadar();
            Console.WriteLine("Tras nadar peso:" + Personal.Peso);
            Console.ReadKey();

        }
    }
}
