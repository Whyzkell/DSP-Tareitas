using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo4
{
    public partial class frmFactorial : Form
    {
        public static Boolean IsNumeric(string valor)

        {
            int result;

            return int.TryParse(valor, out result);

        }
            public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaración de variables
            long factorial = 1;
            int i;

            // Verificar si el texto ingresado es un número
            if (double.TryParse(txtNumero.Text, out double numero))
            {
                // Realizar el cálculo del factorial
                for (i = (int)numero; i >= 1; i--)
                {
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString();
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un número!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtFactorial.Clear();
                txtNumero.Focus();
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNumero.BackColor = Color.White;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
