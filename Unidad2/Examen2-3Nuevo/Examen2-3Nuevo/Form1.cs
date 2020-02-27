using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_3Nuevo
{
    public partial class Form1 : Form
    {
        ClassEmpleado objEmpleado = new ClassEmpleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            objEmpleado.años = int.Parse(txtAños.Text.ToString());
            objEmpleado.Vacaciones();
            lblDias.Text = objEmpleado.diasV.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
