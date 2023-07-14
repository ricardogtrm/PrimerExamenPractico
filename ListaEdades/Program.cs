using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEdades
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> personas = new List<string>();
            personas.Add("Ricardo-23");
            personas.Add("Allan-40");
            personas.Add("Jorge-25");
            personas.Add("Melanie-17");
            personas.Add("Maria-21");

            VerificarEdad(personas);
            Console.ReadKey();
        }

        private static void VerificarEdad(List<string> personas)
        {
            List<string> MayoresEdad = new List<string>();
            List<string> MenoresEdad = new List<string>();

            foreach (var valor in personas)
            {
                string[] persona = valor.Split('-');
                string nombre = persona[0];
                int edad = int.Parse(persona[1]);
                if (edad >= 18)
                {
                    MayoresEdad.Add(valor);
                }
                else
                {
                    MenoresEdad.Add(valor);
                }
            }
            Console.WriteLine("\n-----  Mayores de edad  -----\n");
            MayoresDeEdad(MayoresEdad);
            Console.WriteLine("\n-----  Menores de edad  -----\n");
            MenoresDeEdad(MenoresEdad);
        }

        private static void MenoresDeEdad(List<string> menoresEdad)
        {
            foreach (string persona in menoresEdad)
            {
                string[] person = persona.Split('-');
                Console.WriteLine("Nombre: " + person[0]);
                Console.WriteLine("Edad:   " + person[1]);
                Console.WriteLine("-----------------");
            }
        }
        private static void MayoresDeEdad(List<string> mayoresEdad)
        {
            foreach (string persona in mayoresEdad)
            {
                string[] person = persona.Split('-');
                Console.WriteLine("Nombre: " + person[0]);
                Console.WriteLine("Edad:   " + person[1]);
                Console.WriteLine("-----------------");
            }
        }

    }
}
