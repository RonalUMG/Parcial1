using System;
using System.IO;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            string archivo = @"C:\Users\Ronal Salguero\Desktop\Parcial1\Parcial1\Perfil.txt";

            string[] lineas = File.ReadAllLines(archivo);


            string nombre, Edad, Telefono, Email, hobies, Habilidad, Gusto;

            Console.Write("ingrese un nombre: ");
            nombre = Console.ReadLine();

            Console.Write("ingrese sus Edad: ");
            Edad = Console.ReadLine();

            Console.Write("ingrese sus Telefono: ");
            Telefono = Console.ReadLine();

            Console.Write("ingrese sus Email: ");
            Email = Console.ReadLine();

            Console.Write("ingrese sus Hobbis: ");
            hobies = Console.ReadLine();

            Console.Write("ingrese sus Habilidad: ");
            Habilidad = Console.ReadLine();

            Console.Write("ingrese sus Gusto Musical: ");
            Gusto = Console.ReadLine();


            for (int x = 0; x < lineas.Length; x++)
            {
                lineas[x] = lineas[x].Replace("Nombre", nombre);
                lineas[x] = lineas[x].Replace("Edad", Edad);
                lineas[x] = lineas[x].Replace("Telefono", Telefono);
                lineas[x] = lineas[x].Replace("Email", Email);
                lineas[x] = lineas[x].Replace("Hobbit", hobies);
                lineas[x] = lineas[x].Replace("Habilidad", Habilidad);
                lineas[x] = lineas[x].Replace("Gusto Musical", Gusto);

            }

            System.IO.File.WriteAllLines(@"C:\Users\Ronal Salguero\Desktop\Parcial1\Parcial1\Perfil.html", lineas);

        }
    }
}