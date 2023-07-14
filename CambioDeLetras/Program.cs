using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioDeLetras
{
    public class Program
    {
        static void Main(string[] args)
        {
            string palabra = "Ricardo";
            Console.WriteLine("Palabra inicial => " + palabra);
            Console.WriteLine("Palabra convertida => " + CambioLetras(palabra));

            Console.ReadKey();
        }

        public static string CambioLetras(string palabra)
        {
            string palabraConvertida = "";
            char[] letras = palabra.ToCharArray();
            foreach (char item in letras)
            {
                char let;
                //Si la letra es Z la convierte a una A, si no le suma uno
                //Esto debido a que el tipo de dato char realmente es un 
                //numero, es el valor de una tabla de conversion
                //dependiendo el numero la computadora sabe que valor mostrar
                if (char.IsUpper(item))
                {
                    let = (item == 'Z') ? 'A' : (char)(item + 1);
                }
                else
                {
                    let = (item == 'z') ? 'a' : (char)(item + 1);
                }
                palabraConvertida = palabraConvertida + let;

            }
            return palabraConvertida;
        }
    }
}
