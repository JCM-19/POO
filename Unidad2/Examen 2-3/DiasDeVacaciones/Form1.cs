﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiasDeVacaciones
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
            objEmpleado.antiguedad.Tostring(); 
            objEmpleado.DiasDeVacaciones();
            objEmpleado.dias.ToString();
            objEmpleado.
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
