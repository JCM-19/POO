using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Embotelladora
{
    public partial class FrmEmbotelladora : Form
    {
        public FrmEmbotelladora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClassBotella objBotella= new objbotella();

            objBotella.nivelLlenado = Convert.ToInt32(TxtNivelLlenado.Text);
            MessageBox.Show (objBotella.verificarLlenado());
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {

        }

        private void LblNivelLlenado_Click(object sender, EventArgs e)
        {

        }
    }
}
