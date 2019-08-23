
using System;

namespace dotnet_sesion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            String nombre=Console.ReadLine();
            Console.WriteLine("Ingrese su origen: ");
            String origen=Console.ReadLine();
            Console.WriteLine("Ingrese su destino: ");
            String destino=Console.ReadLine();
            Console.WriteLine("Ingrese su distancia: ");
            double distancia=Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su velocidad: ");
            double velocidad=Double.Parse(Console.ReadLine());              
            double tiempo=distancia/velocidad;
            Console.WriteLine("Estimado {0}, usted llegara de {1}, a {2},en {3}, segundos, gracias",nombre, origen,destino,tiempo);
        }
    }
}
