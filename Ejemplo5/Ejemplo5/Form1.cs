using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo5
{
    public partial class frmCesar : Form
    {

        //valida que el dato recibido es un numero
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        public frmCesar()
        {
            InitializeComponent();
        }

        private void rdbEncriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEncriptar.Checked == true)
            {
                btnEncriptar.Text = "Encriptar";
            }
            else
            {
                
                btnEncriptar.Text = "Desencriptar";
            }
        }

        private void txtLlave_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLlave.BackColor = Color.White;
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            int llave;
            if (int.TryParse(txtLlave.Text, out llave) && llave > 0)
            {
                txtResultado.Clear();
                for (int i = 0; i < txtTexto.Text.Length; i++)
                {
                    char c = txtTexto.Text[i];
                    if (rdbEncriptar.Checked == true)
                    {
                        c = (char)(c + llave);
                    }
                    else
                    {
                        c = (char)(c - llave);
                    }
                    txtResultado.Text += c;
                }
                lblresultado.Text = "Texto encriptado:";
            }
            else
            {
                MessageBox.Show("El dato introducido en la llave es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLlave.Focus();
                txtLlave.Clear();
                txtLlave.BackColor = Color.Red;
            }
        }

        private void rdbDesencriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDesencriptar.Checked == true)
            {
                btnEncriptar.Text = "Desencriptar";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
