using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniaMAntuano.Empleados
{
    public class HorasEmp : Empleado
    {
        private int PrecioHoraTrabajada;
        private int HorasTrabajadas;
        public int  sueldomensual;


        public int getPrecioHoraTrabajada()
        {
            return PrecioHoraTrabajada;
        }
        public void setPrecioHoratrabajada(int PrecioHoraTrabajada)
        {
            this.PrecioHoraTrabajada = PrecioHoraTrabajada;
        }

        public int getHorasTrabajadas()
        {
            return HorasTrabajadas;
        }
        public void setHorastrabajadas(int HorasTrabajadas)
        {
            this.HorasTrabajadas = HorasTrabajadas;
        }

        public void MostrarSueldo()

        {
            Console.WriteLine("Ingrese las horas trabajadas:  ");
            HorasTrabajadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio de la hora trabajada:  ");
            PrecioHoraTrabajada = int.Parse(Console.ReadLine());

            sueldomensual = HorasTrabajadas * PrecioHoraTrabajada;
            Console.WriteLine("El sueldo del empleado temporal es:    " + sueldomensual);
        }

    }
}
