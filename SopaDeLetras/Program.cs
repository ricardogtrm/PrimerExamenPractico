using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SopaDeLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra = "a";
            if (ValidarPalabra(palabra))
            {
                Console.WriteLine("Palabra insertada => " + palabra);
                Console.WriteLine("Palabra ordenada  => " + SopaLetras(palabra));
            }
            else
            {
                Console.WriteLine("La palabra debe contener solo letras");
            }
            Console.ReadKey();
        }

        public static bool ValidarPalabra(string palabra)
        {
            return Regex.IsMatch(palabra, @"^[a-zA-Z]+$");
        }

        public static string SopaLetras(string palabra)
        {
            string palabraOrdenada = "";


            return palabraOrdenada;
        }
    }
}
