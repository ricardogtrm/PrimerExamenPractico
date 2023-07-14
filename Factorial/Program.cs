using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            string secuencia = "";
            int num = 4;
            int numero = num;

            for (int i = 0; i < num; i++)
            {
                secuencia = secuencia + "*" + numero;
                numero--;
            }
            Console.WriteLine("("+secuencia+") = "+factorial(num));
            Console.ReadKey();
        }

        public static int factorial(int numero)
        {
            if (numero <= 0)
            {
                return 1;
            }
            else
            {
                return numero * factorial(numero - 1);
            }
        }
    }
}
