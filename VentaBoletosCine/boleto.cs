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
    public partial class boleto : Form
    {
        public boleto()
        {
            InitializeComponent();
        }

        private void boleto_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }
    }
}
