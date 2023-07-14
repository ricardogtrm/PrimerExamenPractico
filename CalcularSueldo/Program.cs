using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSueldo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Jacobo", "Agami", 500);
            Console.WriteLine("El Empleado: " + empleado1.nombre + " " + empleado1.apellido);
            Console.WriteLine("Tiene un sueldo de: $" + empleado1.CalculaSueldo(15,empleado1.sueldoDiario));
            Console.WriteLine("--------------------------------------------");

            Empleado empleado2 = new Empleado("Alvaro", "González", 400);
            Console.WriteLine("El Empleado: " + empleado1.nombre + " " + empleado1.apellido);
            Console.WriteLine("Tiene un sueldo de: $" + empleado2.CalculaSueldo(12,empleado2.sueldoDiario));
            Console.WriteLine("--------------------------------------------");

            Empleado empleado3 = new Empleado("Mario", "Ramón", 300);
            Console.WriteLine("El Empleado: " + empleado1.nombre + " " + empleado1.apellido);
            Console.WriteLine("Tiene un sueldo de: $" + empleado3.CalculaSueldo(20,empleado3.sueldoDiario));
            Console.ReadKey();
        }
    }
}
