using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    abstract class ClassEmpleado
    {
        //Atributos de la clase
        private string nombre;
        private int fechanacimiento;
        private int diastrabajados;
        private double sueldo;

        //Propiedades de la clase
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }

        }
        public int FechaNacimiento
        {
            set { fechanacimiento = value; }
            get { return fechanacimiento; }
        }
        public int DiasTrabajados
        {
            set { diastrabajados = value; }
            get { return diastrabajados; }
        }
        public double Sueldo
        {
            set { sueldo = value; }
            get { return sueldo; }

        }

        //Constructor de la clase
        public ClassEmpleado()
        {
            nombre = "";
            fechanacimiento = 0;
            diastrabajados = 0;
            sueldo = 0;
        }


        //Metodos de la clase
        public abstract void CalSueldo();
    }
}



