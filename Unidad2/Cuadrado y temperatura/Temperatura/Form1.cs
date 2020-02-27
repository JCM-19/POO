using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    
    public partial class Form1 : Form
    {
        ClassTemperatura objTemperatura = new ClassTemperatura();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtgrados_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objTemperatura.tipo = cmbTipo.Text.ToString();
            objTemperatura.grados = int.Parse(txtgrados.Text.ToString());
           objTemperatura.ConvCelsiusyConvFare();
            lblCentigrados.Text = objTemperatura.Resucel.ToString();
            lblFarenhei.Text = objTemperatura.ResuFare.ToString();
          

        }
    }
}
