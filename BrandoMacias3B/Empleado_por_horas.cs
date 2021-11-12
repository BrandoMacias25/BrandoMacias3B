using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandoMacias3B
{
    public class Empleado_por_horas
    {
        int Precio_Hora ;
        int Horas_Trabajadas;
        int Sueldo_EmpleadoHoras;


        public Empleado_por_horas(int Precio_Hora, int Horas_Trabajadas)
        {
            this.Precio_Hora = Precio_Hora;
            this.Horas_Trabajadas = Horas_Trabajadas;
        } 


        public void SueldoEmpleado_Horas( )
        {
            Sueldo_EmpleadoHoras = Precio_Hora * Horas_Trabajadas;
        }


        public void Datos_EmpleadoHoras()
        {
            Console.WriteLine ("Precio por hora:" + Precio_Hora);
            Console.WriteLine ("Horas trabajadas:" + Horas_Trabajadas);
            Console.WriteLine ("Sueldo del empleado por horas:" + Sueldo_EmpleadoHoras);
        }
    }
}
