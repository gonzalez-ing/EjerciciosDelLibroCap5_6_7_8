using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CadenaPalabra()
        {
            int Numero;
            Numero = int.Parse(NumerotextBox.Text);
            if (Numero == 1)
            {
                PalabratextBox.Text = "Adrian Gonzalez";

            }
            else if (Numero == 2)
            {
                PalabratextBox.Text = "Ramon Gonzalez";
            }
            else if (Numero == 3)
            {
                PalabratextBox.Text = "Ana Mercedes";
            }
            else if (Numero > 3)
            {
                PalabratextBox.Text = "No hay mas Palabra solo hay tres Palabra";
            }
        }

        private void PrecionarClickButton_Click(object sender, EventArgs e)
        {
            CadenaPalabra();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
