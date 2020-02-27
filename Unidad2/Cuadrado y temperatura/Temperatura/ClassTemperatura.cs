using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class ClassTemperatura
    {
        //Atributos de la clase
        public string tipo;
        public double grados;
        public double Resucel;
        public double ResuFare;
        //Metodos de la clase
        public void ConvCelsiusyConvFare()
        {
            switch(tipo)
            {
                case "Celsius":
                    Resucel = (grados * 1.8000) + 32;
                    break;
                case "Fahrenheit":
                    ResuFare = (grados - 32) /1.8000;
                    break;
            }

        }
          
    }
}
