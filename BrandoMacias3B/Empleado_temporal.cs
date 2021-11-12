using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandoMacias3B
{
    public class Empleado_temporal 
    {
        string Fecha_Ingreso;
        string Fecha_Salida;
        int Sueldo_EmpleadoTemporal = 400;


        public Empleado_temporal(string Fecha_Ingreso, string Fecha_Salida)
        {
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Fecha_Salida = Fecha_Salida;
        }


        public void Datos_EmpleadoTemporal()
        {
            Console.WriteLine ("Fecha de ingreso:" + Fecha_Ingreso);
            Console.WriteLine ("Fecha de salida :" + Fecha_Salida);
            Console.WriteLine ("Sueldo del empleado temporal:" + Sueldo_EmpleadoTemporal); 
        }
    }
}
