﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaBoletosCine
{
    public partial class venLineacs : Form
    {
        DBConnection conexionBD;
        Usuario user;

        public venLineacs(DBConnection conexion, Usuario us)
        {
            user = us;
            conexionBD = conexion;
            InitializeComponent();
        }

        private void venLineacs_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ventaBoletos ventaBoletos = new ventaBoletos(conexionBD, user);
            ventaBoletos.ShowDialog();
        }
    }
}
