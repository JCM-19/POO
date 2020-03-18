using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class ClassRepartidor : ClassEmpleado
    {
        //Atributos del repartidor
        private double propinasemanal;
        private string zona;
        private int abonos;

        //Propiedades del repartidor
        public double PropinaSemanal
        {
            set { propinasemanal = value; }
            get { return propinasemanal; }
        }
        public string Zona
        {
            set { zona = value; }
            get { return zona; }
        }
        public int Abonos
        {
            set { abonos = value; }
            get { return abonos; }
        }

        //Constructor
        public ClassRepartidor()
        {
            propinasemanal = 0;
            zona = "";
            abonos = 0;
        }

        //Metodos de la clase
        public override void CalSueldo()
        {
        if (zona =="Zona 1")
            {
                Sueldo = Sueldo * DiasTrabajados + 5;
            }
        else if (zona == "Zona 2")
            {
                Sueldo = Sueldo * DiasTrabajados + 2;
            }
        }
    }
}
    
