using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricidad
{
    class ClassRecibo
    {
        //Atributos de la clase
        public double kwatts;
        public double pago;
        public string HogNeg;
        public string Tipo;

        //Metodos de la clase
        public void ReciboTotal()
        {
            switch (Tipo)
            {
                case "Hogar":
                    {
                        if (kwatts > 0 & kwatts < 250)
                        {
                            pago = kwatts * 0.65;
                        }
                        else if (kwatts > 251 & kwatts < 500)
                        {
                            pago = kwatts * 0.85;
                        }
                        else if (kwatts > 501 & kwatts < 1200)
                        {
                            pago = kwatts * 1.5;
                        }
                        else if (kwatts > 1201 & kwatts < 2100)
                        {
                            pago = kwatts * 2.5;
                        }
                        else if (kwatts >= 2101)
                        {
                            pago = kwatts * 3.5;
                        }

                        break;
                    }
                case "Negocio":
                    {

                        pago = kwatts * 5;

                        break;
                    }


            }
        }
    }
}