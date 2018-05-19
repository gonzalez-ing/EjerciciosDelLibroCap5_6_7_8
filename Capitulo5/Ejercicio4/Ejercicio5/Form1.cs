using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            double Lados, Poligono, perimetroPoligono;

            Lados = double.Parse(NumeroLadotextBox1.Text);
            Poligono = double.Parse(DimecionPoligonotextBox2.Text);

            perimetroPoligono = Lados * Poligono;

            PerimetroPoligonotextBox3.Text = perimetroPoligono.ToString();
        }

        private void CacularButton_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void BorrarBotton_Click(object sender, EventArgs e)
        {
            NumeroLadotextBox1.Clear();
            DimecionPoligonotextBox2.Clear();
            PerimetroPoligonotextBox3.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
