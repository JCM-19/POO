using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conciertoJD
{
    public partial class Form1 : Form
    {
        Asistente objConcierto = new Asistente();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            objConcierto.personas = cmbPersonas.Text.ToString();
            objConcierto.num1 = int.Parse(cmbNumero.Text.ToString());
            objConcierto.num2 = int.Parse(cmbNumero.Text.ToString());
            objConcierto.num3=int.Parse(cmbNumero.Text.ToString());
            objConcierto.num4 = int.Parse(cmbNumero.Text.ToString());
            objConcierto.Registro();
            cmbNumero.Text = "";
            cmbPersonas.Text = "";
            MessageBox.Show("¡Listo!");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = objConcierto.Bebé.ToString();
            label8.Text = objConcierto.Niño.ToString();
            label9.Text = objConcierto.Adulto.ToString();
            label10.Text = objConcierto.Terceraedad.ToString();
        }
    }
}
