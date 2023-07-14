using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSueldo
{
    public class Empleado
    {
        public string nombre;
        public string apellido;
        public int sueldoDiario;

        public Empleado(string nombre, string apellido, int sueldoDiario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoDiario = sueldoDiario;
        }

        public int CalculaSueldo(int diasTrabajados, int sueldoDiario)
        {
            return diasTrabajados * sueldoDiario;
        }
    }
}
