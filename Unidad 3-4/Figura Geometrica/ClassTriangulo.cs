using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura_Geometrica
{
    class ClassTriangulo:ClassFigurasGeometricas 
    {
        //Atributos de la clase
        private float altura;
        public float Altura { get; set; }
        public override void CalPerimetro()
        {
            Perimetro = Lado * 3;
        }
        public override void CalArea()
        {
            Area = Lado * altura;
        }

    }
}
