using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[100];
            int cantidad = 0;
            string nombre;

            Console.WriteLine("Ingrese nombres (escriba 'fin' para terminar):");

            do
            {
                nombre = Console.ReadLine();

                if (nombre.ToLower() != "fin")
                {
                    nombres[cantidad] = nombre;
                    cantidad++;
                }

            } while (nombre.ToLower() != "fin");

            Console.WriteLine("Saludos:");

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Hola {nombres[i]}!");
            }
        }
    }
}