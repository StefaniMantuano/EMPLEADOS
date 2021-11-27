using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMAntuano.Empleados
{
    public class TemporalEmp: Empleado

    {
        private string fechaingreso;
        private string fechasalida;
      

        public string getfechaingreso()
        {
            return fechaingreso;
        }
        public void setfechaingreso (string fechaingreso)
        {
            this.fechaingreso = fechaingreso;
        }


        public string getfechasalida()
        {
            return fechasalida;
        }
        public void setfechasalida(string fechasalida)
        {
            this.fechasalida = fechasalida;
        }


        public void MostrarSueldo()
            
        {

         int Sueldofijo =400;

         Console.WriteLine("El sueldo fijo del empleado temporal es :      " + Sueldofijo);

        }

    }
}
