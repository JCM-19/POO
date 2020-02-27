using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadoDeUnCuadradoAreaYPerimetro
{
    class ClassCuadrado
    {
        //Atributos
        public int lado = 0;
        public int area = 0;
        public int perimetro = 0;

        //Metodos
        public void CalArea()
        {
            area = lado * lado;

        }
        public void CalPerimetro()
        {
            perimetro = lado * 4;
        }
    }
}
