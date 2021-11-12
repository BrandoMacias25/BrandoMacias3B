using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandoMacias3B
{
    public class Empleado 

    {
        string Apellidos;
        string Nombres;
        int Edad;
        string Departamento;

        public Empleado(string Apellidos, string Nombres, int Edad, string Departamento)
        {
            this.Apellidos = Apellidos;
            this.Nombres = Nombres;
            this.Edad = Edad;
            this.Departamento = Departamento;
        }


        public void Datos_Empleado()
        {
            Console.WriteLine("Apellidos:" + Apellidos);
            Console.WriteLine("Nombres:" + Nombres);
            Console.WriteLine("Edad:" + Edad);
            Console.WriteLine("Departamento:" + Departamento);
        }
    }
}
