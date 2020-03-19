using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class ClassAereo
    {
        //Atributos de la clase
        public int NumTurbinas, NumAlas, NumHelices;
        public string TipoAereo;
        public ClassAereo()
        {
            NumAlas = 0;
            NumTurbinas = 0;
            NumHelices = 0;
            TipoAereo = "";
        }
        public string enVuelo (string Estado)
        {
            return "El " + TipoAereo + "esta" + Estado;
        }
    }
}
