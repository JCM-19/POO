using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones20
{
    class ClassCalificaciones
    {
        //Atributos de la clase 
        public int cal = 0;
        public int aprobados = 0;
        public int reprobados = 0;
        int contador = 0;
        public double promedio = 0;
        int suma = 0;
        
        //Métodos para retornar promedio 
        public void capturarCalificación()     
        {
            if (cal >= 70)
            {
                aprobados = aprobados + 1;
                suma = suma + cal;
            }       
            else
            {
                reprobados = reprobados + 1;
                suma = suma + cal;
            }
            contador++;
            promedio = suma / contador;   
        }
    }
}
