using System;

namespace EjercicioXI
{
    class Program
    {
        static void Main(string[] args)
        {
            do

            {

                Console.WriteLine("Ingrese una frase a continuación:");

                string ingreso = Console.ReadLine().ToLower();



                if (ingreso.Contains('á') || ingreso.Contains("é") || ingreso.Contains("í") || ingreso.Contains("ó") || ingreso.Contains("ú"))

                {

                    ingreso = ingreso.Replace("é", "e");

                    ingreso = ingreso.Replace("í", "i");

                    ingreso = ingreso.Replace("ó", "o");

                    ingreso = ingreso.Replace("ú", "u");

                    ingreso = ingreso.Replace("á", "a");



                    Console.WriteLine("\nSu frase sin acentos es: " + ingreso);

                }

                else

                    Console.WriteLine("\nNo se han ingresado vocales acentuadas");



                Console.ReadKey();



            } while (true);
        }
    }
}
