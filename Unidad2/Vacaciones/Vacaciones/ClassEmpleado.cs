using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacaciones
{
    class ClassEmpleado
    {
        //Atributos de la clase
        public int antiguedad = 0;
        public int diasV = 0;
        //Metodos de la clase
        public void DiasDeVacaciones()
        {
            if (antiguedad > 0 & antiguedad <= 5)
            {
                diasV = diasV + 5;
            }
            else if (antiguedad >= 6 & antiguedad <= 10)
            {
                diasV = diasV + 10;
            }
            else if (antiguedad>=10 & antiguedad <20)
            {
                diasV = diasV + ((antiguedad - 10) * 1);
            }
            else if (antiguedad>=20)
            {
                diasV = 10 + ((antiguedad - 20) * 2);
                if (antiguedad>45)
                {
                    diasV = 45;
                }
            }
        }
    }
}
