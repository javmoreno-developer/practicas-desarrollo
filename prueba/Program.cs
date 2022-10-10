using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practica2();   
        }
        #region Practica1
        static void Practica1()
        {
            Console.WriteLine("Introduzca un valor para un radio");
            int numero = int.Parse(Console.ReadLine());

            double resultado = Math.PI * Math.Pow(numero, 2);
            Console.WriteLine($"El area del circulo es: {resultado}");
        }
        #endregion

        #region Practica 2
        static void Practica2()
        {
            const int PUEDE_CONDUCIR = 18;
            const string TIENE_CARNET = "S";

            Console.WriteLine("Vamos a evaular si puedes conducir");
            Console.WriteLine("Introduce tu edad por favor: ");
            int edad = Int32.Parse(Console.ReadLine());

            if(edad < 18)
            {
                Console.WriteLine("No puedes conducir,eres menor");
            } else
            {
                Console.WriteLine("Tienes carnet S/N: ");
                string hasCarnet = Console.ReadLine();

                if(String.Equals(hasCarnet.ToUpper(),TIENE_CARNET))
                {
                    Console.WriteLine("Puedes conducir");
                } else
                {
                    Console.WriteLine("No puedes conducir");
                }
            }

        }
        #endregion
    }
}
