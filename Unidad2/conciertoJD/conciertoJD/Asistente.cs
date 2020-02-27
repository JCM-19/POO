using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conciertoJD
{
     public class Asistente
    {
        //Atributos de la clase
        public int Bebé = 0, Niño = 0, Adulto = 0, Terceraedad = 0;
        public int num1 = 0, num2 = 0, num3 = 0, num4 = 0;
        public string personas;
        //Metodos de la clase
        public void Registro ()
        {
            switch (personas)
            {
                case "Bebé":
                    Bebé = Bebé + num1;
                    break;
                case "Niño":
                    Niño = Niño + num2;
                    break;
                case "Adulto":
                    Adulto = Adulto + num3;
                    break;
                case "Tercera edad":
                    Terceraedad = Terceraedad + num4;
                    break;
            }
        }
    }
}
