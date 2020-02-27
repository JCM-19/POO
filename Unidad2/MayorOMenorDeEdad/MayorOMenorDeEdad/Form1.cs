using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorOMenorDeEdad
{
    public partial class Form1 : Form
    {
        ClassPersona ObjEdad = new ClassPersona();
        public Form1()
       {
            InitializeComponent();
        }

        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            ObjEdad.añoAc = int.Parse(DateTime.Today.Year.ToString());
            ObjEdad.mesAc = int.Parse(DateTime.Today.Year.ToString());
            ObjEdad.diaAc = int.Parse(DateTime.Today.Year.ToString());
            ObjEdad.añoNac = int.Parse(dateTimePicker1.Value.Year.ToString());
            ObjEdad.mesNac = int.Parse(dateTimePicker1.Value.Year.ToString());
            ObjEdad.diaNac = int.Parse(dateTimePicker1.Value.Year.ToString());
            ObjEdad.MayorEdad();
            lblEdadMayMen.Text = ObjEdad.mayor.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

