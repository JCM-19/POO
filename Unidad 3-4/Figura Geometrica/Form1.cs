using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figura_Geometrica
{
   
    public partial class Form1 : Form
    {
        ClassCuadrado objCuadrado = new ClassCuadrado();
        ClassTriangulo objTriangulo = new ClassTriangulo();
        ClassCirculo objCirculo = new ClassCirculo();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            objCuadrado.Lado = Convert.ToDouble(txtMedidaCuadrado.Text);
            objCuadrado.CalArea();
            objCuadrado.CalPerimetro();
            lblPerimetroCuadrado.Text = objCuadrado.Perimetro.ToString();
            lblAreaCuadrado.Text = objCuadrado.Area.ToString();

        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            objTriangulo.BaseTriangulo = Convert.ToDouble(txtBaseTriangulo.Text);
            objTriangulo.Altura = int.Parse(txtAlturaTriangulo.Text);
            objTriangulo.CalArea();
            objTriangulo.CalPerimetro();
            lblAreaTriangulo.Text = objTriangulo.Area.ToString();
            lblPerimetroTriangulo.Text = objTriangulo.Perimetro.ToString();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            objCirculo.Radio = Convert.ToDouble(txtRadioCirculo.Text);
            objCirculo.Circunferencia = Convert.ToDouble(txtCircunferenciaCirculo.Text);
            objCirculo.CalArea();
            objCirculo.CalPerimetro();
            lblAreaCirculo.Text = objCirculo.Area.ToString();
            lblPerimetroCirculo.Text = objCirculo.Perimetro.ToString();
        }
    }
}
