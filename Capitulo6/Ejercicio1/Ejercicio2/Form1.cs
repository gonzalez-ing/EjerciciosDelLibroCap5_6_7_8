﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convertir()
        {
            float Numero = float.Parse(textBox1.Text);
            double Resultado;
            Resultado = (Numero * 9 / 5) + 32;
            // this.listBox1.Text = Resultado;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Convertir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
