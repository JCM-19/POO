using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiasDeVacaciones
{
    class ClassEmpleado
    {
        //Atributos de la clase
        public int años = 0;
        public int dias = 0;
        //Metodos de la clase
        public void DiasDeVacaciones()
        {
            if (años>0 & años<=5)
            {
                dias = 5;
            }
            else if (años>6 & años<=10)
            {
                dias = 10;
            }
            else if (años >10 & años<=20)
            {
                dias = años-10+1;
            }
            else if (años>20 & años<=45)
            {
                dias = (años-10)*2/20;
            }

        }
    
    }
}
