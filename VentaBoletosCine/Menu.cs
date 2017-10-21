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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ventaBoletos  venta = new ventaBoletos();
            venta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Capturista capturista = new Capturista();
            capturista.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            membresias mem = new membresias();
            mem.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boleto bole = new boleto();
            bole.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            venLineacs venta = new venLineacs();
            venta.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ventaUsuario ventaUsuario = new ventaUsuario();
            ventaUsuario.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            funcionesSalas funcionesSala = new funcionesSalas();
            funcionesSala.Show();
        }
    }
}
