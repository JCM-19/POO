using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Memorama
{
    class Class1
    {
        //Atributos de la clase
        int TamañoColumnasFilas;
        int Movimientos;
        int CantidaDeCartasVolteadas;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual;

        //constructor
        public Movimietos1()
        {
            TamañoColumnasFilas = 4;
            lblMovimiento.Text = "0";
            CantidaDeCartasVolteadas = 0;
            Movimientos = 0;
            CartaActual = 0;
        }


        
    }
}
