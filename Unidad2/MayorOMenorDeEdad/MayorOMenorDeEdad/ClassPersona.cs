using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorOMenorDeEdad
{
    class ClassPersona
    {
        //Atributos de la clase
        public int añoNac = 0;
        public int mesNac = 0;
        public int diaNac = 0;
        //Atributos para el metodo
        public int añoAc = 0;
        public int mesAc = 0;
        public int diaAc = 0;
        public String mayor;
        //Metodos de la clase
        public void MayorEdad()
        {
            if (añoAc - añoNac > 18)
            {
                mayor = "Es mayor de edad";
            }
            else if (añoAc - añoNac == 18) ;
            {
                if (mesAc > mesNac)
                {
                    mayor = "Es mayor de edad";
                }
                else if (mesAc == mesNac)
                {
                    if (diaAc>diaNac)
                    {
                        mayor = "Es mayor de edad";
                    }
                }
            }
        }
    }
}
