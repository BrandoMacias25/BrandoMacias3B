using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandoMacias3B
{
    class Program
    {

        public static int eleccion;

        static void Main(string[] args)
        {

            do
            {

                Console.WriteLine("1. Datos del Empleado ");
                Console.WriteLine("2. Trabajo Temporal ");
                Console.WriteLine("3. Trabajo por horas ");
                Console.WriteLine("4. Trabajo Fijo ");
                Console.WriteLine("5. Salir  ");
                eleccion = int.Parse(Console.ReadLine());
                if (eleccion == 1)
                {
                    Empleado empleado = new Empleado ("Perez Moreira", "Jose Roberto", 36, "Finanzas");
                    empleado.Datos_Empleado();
                }

                else if (eleccion == 2)
                {
                    Empleado_temporal empleado_temporal = new Empleado_temporal ("25-06-2021" , "25-09-2021");
                    empleado_temporal.Datos_EmpleadoTemporal();
                }

                else if (eleccion == 3)
                {
                    Empleado_por_horas empleado_por_horas = new Empleado_por_horas (2 , 90);
                    empleado_por_horas.SueldoEmpleado_Horas();
                    empleado_por_horas.Datos_EmpleadoHoras();
                }

                else if (eleccion == 4)
                {
                    Empleado_fijo empleado_fijo = new Empleado_fijo("01-01-2010", 400, 100, 11);
                    empleado_fijo.SueldoEmpleado_Fijo();
                    empleado_fijo.Datos_EmpleadoFijo();
                }

            } while (eleccion != 5);
        }
    }
}
