using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandoMacias3B
{
    public class Empleado_fijo 
    {
        string Fecha_Entrada;
        int Sueldo_Fijo = 400;
        int Complemento_Anual;
        int Años_Trabajados;
        int Sueldo_EmpleadoFijo;


        public Empleado_fijo(string Fecha_Entrada, int Sueldo_Fijo, int Complemento_Anual, int Años_Trabajados)
        {
            this.Fecha_Entrada = Fecha_Entrada;
            this.Sueldo_Fijo = Sueldo_Fijo;
            this.Complemento_Anual = Complemento_Anual;
            this.Años_Trabajados = Años_Trabajados;
        }


       public void SueldoEmpleado_Fijo ()
        {
            Sueldo_EmpleadoFijo = Sueldo_Fijo + Complemento_Anual * Años_Trabajados;     
        }


        public void Datos_EmpleadoFijo()
        {
            Console.WriteLine ("Fecha de entrada:" + Fecha_Entrada);
            Console.WriteLine ("Sueldo Fijo:" + Sueldo_Fijo);
            Console.WriteLine ("Complemento Anual:" + Complemento_Anual);
            Console.WriteLine ("Años Trabajados:" + Años_Trabajados);
            Console.WriteLine ("Sueldo del empleado fijo:" + Sueldo_EmpleadoFijo);
        }

    }
}
