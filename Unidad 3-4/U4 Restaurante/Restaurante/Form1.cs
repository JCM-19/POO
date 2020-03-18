using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        //objetos
        ClassMesero objMesero = new ClassMesero();
        ClassCajero objCajero = new ClassCajero();
        ClassRepartidor objRepartidor = new ClassRepartidor();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbDiasTrabRepartidor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMesero_Click(object sender, EventArgs e)
        {
            objMesero.Nombre = Convert.ToString(txtNombreMesero.Text);
            DateTime FechaNacimiento = dtpMesero.Value;
            objMesero.Propina = Convert.ToDouble(txtPropinasMesero.Text);
            objMesero.DiasTrabajados = int.Parse(cmbDiasTrabMesero.Text);
            objMesero.Sueldo = Convert.ToDouble(txtSueldoMesero.Text);
            objMesero.CalSueldo();
            MessageBox.Show("El señor(a) " + objMesero.Nombre + " con fecha de nacimiento " + FechaNacimiento + " ganó " + objMesero.Sueldo);
        }

        private void btnRepartidor_Click(object sender, EventArgs e)
        {
            objRepartidor.Nombre = Convert.ToString(txtNombreRepartidor.Text);
            DateTime FechaNacimiento = dtpFechaNacCajero.Value;
            objRepartidor.PropinaSemanal = Convert.ToDouble(txtPropinasRepartidor.Text);
            objRepartidor.DiasTrabajados = int.Parse(cmbDiasTrabRepartidor.Text);
            objRepartidor.Sueldo = Convert.ToDouble(txtSueldoRepartidor.Text);
            objRepartidor.CalSueldo();
            MessageBox.Show("El señor(a) " + objRepartidor.Nombre + " con fecha de nacimiento " + FechaNacimiento + " ganó " + objRepartidor.Sueldo);

        }

        private void btnCajero_Click(object sender, EventArgs e)
        {
            objCajero.Nombre = Convert.ToString(txtNombreCajero.Text);
            DateTime FechaNacimiento = dtpFechaNacCajero.Value;
            objCajero.NumCaja = Convert.ToString(cmbNumeroCaja.Text);
            objCajero.DiasTrabajados = int.Parse(cmbDiasTrabCajero.Text);
            objCajero.Sueldo = Convert.ToDouble(txtSueldoCajero.Text);
            objCajero.CalSueldo();
            MessageBox.Show("El señor(a) " + objCajero.Nombre + " con fecha de nacimiento " + FechaNacimiento + " ganó " + objCajero.Sueldo);
        }

        private void cmbDiasTrabMesero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpMesero_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
