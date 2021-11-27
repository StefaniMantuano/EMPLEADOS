using System;

namespace StefaniaMAntuano.Empleados
{
    // clase para el inicio  
    public class Program
    {
        static void Main(String[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Datos();
            empleado.Escoger();
            


            //Empleado fijo
            FijoEmp empleadofijo = new FijoEmp();
            empleadofijo.MostrarSueldo();
            


            //Empleado Temporal
            TemporalEmp temporal = new TemporalEmp();
            temporal.MostrarSueldo();
           


            //Empleado por horas
            HorasEmp empleadohoras = new HorasEmp();
            empleadohoras.MostrarSueldo();


        }
    }
}