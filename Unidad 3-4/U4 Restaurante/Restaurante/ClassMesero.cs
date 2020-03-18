using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class ClassMesero:ClassEmpleado 
    {
        //Atributos del mesero
        private double propina;
        private double sueldopropina;
        //propiedades
        public double Propina
        {
            set { propina = value; }
            get { return propina; }
         }
        public double SueldoPropina
        {
            set { sueldopropina = value; }
            get { return sueldopropina; }
        }
        //constructor 
        public ClassMesero()
        {
            propina = 0;
            sueldopropina = 0;
        }
        //metodos de la clase
        public override void CalSueldo()
        {
            Sueldo = (DiasTrabajados * Sueldo) + SueldoPropina;
        }
    }
}
