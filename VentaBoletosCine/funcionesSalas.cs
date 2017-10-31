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
    public partial class funcionesSalas : Form
    {
        DBConnection conexionBD;

        public funcionesSalas(DBConnection conexion)
        {
            conexionBD = conexion;
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if( (textBox1.Text != "" )&&
                (textBox2.Text != "" )&&
                (textBox3.Text != "" )&&
                (textBox4.Text != "" )&&
                (textBox5.Text != "" )
                )
            {

            }
            else
            MessageBox.Show("Ingrese todos los datos para poder guardar el registro");

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)&& e.KeyChar !='\b')
            {
                e.Handled = true;
            }
            else
                MessageBox.Show("Ingrese solamente numeros ");


        }

        /*
         * Descripción: Configuración para la tecla TAB de todos 
         * los elementos del form 
         */
        public void configuraIndex()
        {
            this.textBox1.TabIndex = 0;
            this.textBox2.TabIndex = 1;
            this.textBox3.TabIndex = 2;
            this.textBox4.TabIndex = 3;
            this.textBox5.TabIndex = 4;
            this.button1.TabIndex = 5;
            this.button2.TabIndex = 5;
            this.button3.TabIndex = 5;
            this.button4.TabIndex = 5;
            
        }

        private void funcionesSalas_Load(object sender, EventArgs e)
        {
            configuraBotones();
            configuraIndex();


        
        }

        /*
         *Descripción: Este método deshailita los textbox para proteger la información
         *que sea modificada por error, etc. 
         */
        public void configuraBotones()
        {

            textBox1.Enabled = false ;
            textBox2.Enabled = false ;
            textBox3.Enabled = false ;
            textBox4.Enabled = false ;
            textBox5.Enabled = false ;
        }

        /*
         * Descripción: Este método habilita  os botones para poder hacer su edición
         */
        public void habilitaBotones()
        {

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            habilitaBotones();
        }
    }
}
