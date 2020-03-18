using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class ClassCajero : ClassEmpleado
    {
        //Atributos de la clase
        private string numcaja;

        //Propiedades de la clase
        public string NumCaja
        {
            set { numcaja = value; }
            get { return numcaja; }
        }

        //Constructor
        public ClassCajero()
        {
            numcaja = "";
        }

        //Metodos de la clase
        public override void CalSueldo()
        {
            if (NumCaja == "Caja 1")
            {
                Sueldo = (Sueldo * DiasTrabajados) + (Sueldo * .3);
            }
            else if (NumCaja == "Caja 2")
            {
                Sueldo = Sueldo * DiasTrabajados;
            }
        }
    }
}