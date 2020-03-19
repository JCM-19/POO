using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_4
{
    class ClassOperacion
    {
        //Atributos de la clase
       private int Valor1;
        private int Valor2;
       private double Resultado;
        public ClassOperacion()
        {
            Valor1 = 0;
            Valor1 = 0;
                Resultado = 0;
        }
        public void operaciones()
        {
            Resultado = Valor1 + Valor2;
            Resultado = Valor1 - Valor2;
            Resultado = Valor1 * Valor2;
            Resultado = Valor1 / Valor2;
        }
        
        
         
    }
}
