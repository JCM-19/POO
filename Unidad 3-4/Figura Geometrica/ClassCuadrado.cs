using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura_Geometrica
{
    class ClassCuadrado:ClassFigurasGeometricas
    {
        //atributos de la clase
        public override void CalPerimetro()
        {
            Lado = Lado * 4;
        }
        public override void CalArea()
        {
            Lado = Lado * Lado;
        }
    }
}
