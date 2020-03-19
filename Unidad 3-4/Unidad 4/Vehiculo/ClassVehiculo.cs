using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class ClassVehiculo
    {
        //Atributos de la clase
        public string TipoCombustible, color;
        public int NumeroLlantas;
        public int NumeroPuertas;
        public int NumeroVentanas;
        //Constructor de la clase se llama igual y se ejecuta automaticamente 
        public ClassVehiculo()
        {
            TipoCombustible = "";
            color = "Blanco";
            NumeroLlantas = 1;
            NumeroPuertas = 0;
            NumeroVentanas = 0;

        }
        public string ArrancarMotor(string sonido)
        {
            return "Se arranca el motor" + sonido;
        }
        public string PararMotor(string sonido)
        {
            return "Se para el motor" + sonido;
        }
    
    }
}
