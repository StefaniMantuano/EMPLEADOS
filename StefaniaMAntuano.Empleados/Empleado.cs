using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMAntuano.Empleados
{
    public class Empleado
    { 
        private string Nombres;
        private string Apellidos;
        private int Edad;
        private string Departamento;

       
        public string getNombres()
        {
            return Nombres;
        }

        public void setNombres(string Nombres)
        {
            this.Nombres = Nombres;
        }


        public string getApellidos()
        {
            return Apellidos;
        }

        public void setApellidos(string Apellidos)
        {
            this.Apellidos = Apellidos;
        }


        public int getEdad()
        {
            return Edad;
        }

        public void setEdad(int Edad)
        {
            this.Edad = Edad;
        }


        public string getDepartamento()
        {
            return Departamento;
        }

        public void setDireccion(string Departamento)
        {
            this.Departamento= Departamento;
        }
       

        public void Datos()
        {
            Console.WriteLine("Nombres del empleado:      ");
            Nombres = Console.ReadLine();

            Console.WriteLine("Apellidos del empleado:      " );
            Apellidos = Console.ReadLine(); 
            
            Console.WriteLine("Edad del empleado:      ");
            Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Departamento del empleado:      " );
            Departamento = Console.ReadLine();
        }

        public void Escoger()
        {
            int empleador;
            Console.WriteLine("Elija que tipo de empleado es: \nEmpleado Fijo----1 \nEmpleado Temporal-----2\nEmpleado por hora----3");
            empleador = int.Parse(Console.ReadLine());

            if (empleador== 1)
            {
                Console.WriteLine("Ha escogido empleado fijo");
                FijoEmp fijoEmp = new FijoEmp();
            }

            else if (empleador == 2)
            {
                Console.WriteLine("Ha escogido empleado temporal");
                TemporalEmp temporal = new TemporalEmp();
            }
            else if (empleador ==3)
            {
                Console.WriteLine("Ha escogido a empleado por horas");
                HorasEmp horas = new HorasEmp();
                
            }
        }


    }
}
