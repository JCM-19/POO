using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura_Geometrica
{
  class ClassCirculo:ClassFigurasGeometricas 
    {
        //Atributos de la clase
        private double pi = 3.14;
        private double radio;
        public double Pi { get; set; }
        public double Radio { get; set; }
        public override void CalPerimetro()
        {
            Perimetro = (Lado * Lado) * 3.14;
        }
        public override void CalArea()
        {
            Area= 3.14 * (Lado) * 3.14 * (Lado);

        }

    }
}
