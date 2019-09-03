using System;

namespace Semana_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA
            Console.WriteLine("¿Como te llamas?");
            var nombre = Console.ReadLine();
            Console.WriteLine("¿Que edad tienes?");
            var edad=Convert.ToInt32(Console.ReadLine());
            var edadAmigo=edad+5;
            //SALIDAS
            Console.WriteLine("Hello "+nombre);
            Console.WriteLine("Hallo {0} " ,nombre);
            Console.WriteLine($"Hola {nombre}");
            Console.WriteLine(edad);
            Console.WriteLine(edadAmigo);
            Console.Write("Hola nena");
            Console.Write("¡Como estas?");
        }
    }
}
