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
            Console.WriteLine("Introduzca un valor para un radio");
            int numero = int.Parse(Console.ReadLine());

            double resultado = Math.PI * Math.Pow(numero, 2);
            Console.WriteLine($"El area del circulo es: {resultado}");
        }
    }
}
