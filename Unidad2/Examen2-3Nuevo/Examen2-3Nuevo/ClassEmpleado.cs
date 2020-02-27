using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_3Nuevo
{
    class ClassEmpleado
    {
        //Atributos de la clase
        public int años = 0;
        public int diasV = 0;
        //Metodos de la clase
        public void Vacaciones()
        {
            if (años >= 1 & años < 5) 
            {
                diasV = 5;
            }
            if (años >= 6 & años < 10) 
            {
                diasV = 10;
            }
            if (años >= 11 & años < 20) 
            {
                diasV = (años - 10) + 10;
            }
            if (años >= 21 & años <=32) 
            {
                diasV = (años - 10) * 2;
            }

        }

    }
}
