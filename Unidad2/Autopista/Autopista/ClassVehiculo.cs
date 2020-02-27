using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopista
{
    class ClassVehiculo
    {
        //Atributos de la clase
        public string Vehiculo;
        public int cobro;
        //Metodos de la clase
        public void CobroPorVehiculo()
        {
        switch (Vehiculo)
            {
                case "Motocicleta":
                    cobro = 50;
                    break;
                case "Automovil":
                    cobro = 112;
                    break;
                case "Autobus":
                    cobro = 170;
                    break;
                case "Trailer":
                    cobro = 250;
                    break;


            }

        {
        }
        }
    }
}
