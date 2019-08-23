using System;

namespace wmedina___sesion_1 /*paquete */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My app: ");
            Console.WriteLine("Ingrese su nobre:");
            String name = Console.ReadLine();
            Console.WriteLine("Ingrese su pasword: ");
            String pass = Console.ReadLine();
            Console.WriteLine("Ingrese sus edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello {0}", name);
            if (edad > 18)
            {
                Console.WriteLine("Puede Beber!");
            }
            else
            {
                Console.WriteLine("No debe Beber!");
            }

        }
    }
}
