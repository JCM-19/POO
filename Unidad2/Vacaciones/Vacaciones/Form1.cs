using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacaciones
{
  
    public partial class Form1 : Form
    {
        ClassEmpleado objEmpleado = new ClassEmpleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            objEmpleado.antiguedad = int.Parse(txtAños.Text);
            objEmpleado.DiasDeVacaciones();
            lblDias.Text = objEmpleado.diasV.ToString();
            txtAños.Text="";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
