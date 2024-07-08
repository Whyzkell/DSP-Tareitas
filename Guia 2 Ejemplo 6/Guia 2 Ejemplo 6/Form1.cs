using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2_Ejemplo_6
{
    public partial class frmReves : Form
    {
        public frmReves()
        {
            InitializeComponent();
        }

        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^\d+$");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            long numero;
            if (long.TryParse(txtNumero.Text, out numero) && numero > 0 && numero <= 999999)
            {
                // ...
            }
            else
            {
                MessageBox.Show("El dato que ingreso no es un número válido", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Clear();
                txtNumero.BackColor = Color.Red;
            }

            string numeroStr = numero.ToString();
            char[] chars = numeroStr.ToCharArray();
            Array.Reverse(chars);
            string revesStr = new string(chars);
            txtReves.Text = revesStr;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtReves.Clear();
        }
    }
}
