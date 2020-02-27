using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LadoDeUnCuadradoAreaYPerimetro
{
    public partial class frmCuadrado : Form
    {
        ClassCuadrado objlado = new ClassCuadrado();
        public frmCuadrado()
        {
            InitializeComponent();
        }

        private void txtLados_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            if (txtLados.Text == "")
            {
                errorProvider1.SetError(txtLados, "Pon algo carnal");
                txtLados.Focus();
                return;
            }
            errorProvider1.SetError(txtLados, "");

            objlado.lado = int.Parse(txtLados.Text.ToString());
            objlado.CalArea();
            lblArea.Text = objlado.area.ToString();
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            if (txtLados.Text == "")
            {
                errorProvider1.SetError(txtLados, "Pon algo carnal");
                txtLados.Focus();
                return;
            }
            errorProvider1.SetError(txtLados, "");

            objlado.lado = int.Parse(txtLados.Text.ToString());
            objlado.CalPerimetro();
            Lblperimetro.Text = objlado.perimetro.ToString();
        }
    }
}
