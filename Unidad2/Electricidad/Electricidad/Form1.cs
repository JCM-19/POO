using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricidad
{
    
    public partial class Form1 : Form
    {
        ClassRecibo objRecibo = new ClassRecibo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            objRecibo.Tipo = cmbHogarNeg.Text.ToString();
        objRecibo.kwatts=Convert.ToDouble(textBox1.Text);
            objRecibo.ReciboTotal();
            lblPago.Text = objRecibo.pago.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
