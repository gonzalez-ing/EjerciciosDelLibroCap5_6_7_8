using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convertir()
        {
            int Numero = int.Parse(textBox1.Text);
            int Resultado;
            Resultado = Numero - 32 / 8;
            listBox1.Items.Add(Resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Convertir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
