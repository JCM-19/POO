using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura_Geometrica
{
    abstract class ClassFigurasGeometricas
    {
        //Atributos de la clase
        private double  perimetro;
        private double  area;
        private double  lados;
        private double basetriangulo;
        private double altura;
        private double radio;
            private double cinrcunferencia;
        
        public double Perimetro { get; set;}
        public double  Area { get; set; }
        public double Lado { get; set; }
        public double BaseTriangulo { get; set; }
        public double Altura { get; set; }
        public double Circunferencia { get; set; }


       
        public abstract void CalPerimetro();
        public abstract void CalArea();
        

        



    } 

   

}
