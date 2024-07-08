using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2_Ejemplo_7
{
    public partial class frmULAM : Form
    {
        public frmULAM()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtnumero.Text);
            if (number <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo");
                return;
            }

            lstLista.Items.Clear();
            lstLista.Items.Add(number);

            while (number != 1)
            {
                if (number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    number = number * 3 + 1;
                }
                lstLista.Items.Add(number);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
