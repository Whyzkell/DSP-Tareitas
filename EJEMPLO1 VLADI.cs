using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string mensa;
        int conta;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {
            mensa = "Aun no ha presionado boton Contar";
            lblMensa.Text = mensa;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
           conta=  conta + 1;
            mensa = "Presiono boton Contar, un total de veces de " +
                Convert.ToString(conta) + "veces";
            lblMensa.Text = mensa;

        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            conta = 0; 
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
