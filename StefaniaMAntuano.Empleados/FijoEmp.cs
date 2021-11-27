using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMAntuano.Empleados
{ 
    public class FijoEmp:Empleado
       { 
        private int Añoentrada;
        private int Añoactual;
        public int Sueldo;
        public int Base;
        public int Complementoanual;
        public int Añostrabajados;

       
        public int getAñoentrada()
        {
            return Añoentrada;
        }
        public void setAñoentrada ( int Añoentrada)
        {
            this.Añoentrada = Añoentrada;
        }

         public void MostrarSueldo()
        {
          //Ingresar datos
          Console.WriteLine("Ingrese el año de entrada:  ");
             Añoentrada = int.Parse(Console.ReadLine());

          Console.WriteLine("Ingrese el año actual:  ");
             Añoactual = int.Parse(Console.ReadLine());

          Console.WriteLine("Ingrese la base del sueldo del empleador:  ");
             Base = int.Parse(Console.ReadLine());

        // Operaciones
        int Complementoanual = 20;
        
            Añostrabajados = Añoactual - Añoentrada;
            Sueldo = Base + (Complementoanual * Añostrabajados);

        //Mostrar sueldo
            Console.WriteLine("El sueldo del empleado fijo es:   " + Sueldo);
         }
        
    }
}
