using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_2_Vladimir_Penado
{
    public partial class Form1 : Form
    {

        double TasaI;
        public static Boolean EsNumero(string valor)
        {
        //retorna true si valor string del parametro representa un valor entero
            int result;
            return int.TryParse(valor, out result);
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void rdbInteres3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInteres3.Checked == true)
            {
                 txtTasaInterEX.Enabled = true;
                 txtTasaInterEX.Focus();
                 }
             else
                 {
                 txtTasaInterEX.Text = "0";
                 txtTasaInterEX.Enabled = false;
            }
        }

        private void rdbInteres1_Click(object sender, EventArgs e)
        {
          

            TasaI = 0.05;
        }

        private void rdbInteres2_Click(object sender, EventArgs e)
        {
           

            TasaI = 0.075;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            //Declaracion de variables a utilizar
            string NomEmpre;
            // valor de prestamo inicial y valor que pagara al finalizar plazo
            double MontoInic = 0, MontoFin = 0;
            int Tiempo; //tiempo en año para pagar prestamo
            NomEmpre = txtEmpresa.Text; //toma texto escrito en contorl txtEmpresa
            NomEmpre = NomEmpre.Trim(); //Quita el espacio-blanco al inicio-final
            if (NomEmpre.Length == 0)
            { // evalua si ha escrito nombre de empresa
                MessageBox.Show("Debe indicar Nombre de la empresa", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Focus(); //metodo para que control txtEmpresa reciba cursor
                return; //finaliza ejecucion de este procedimiento
            }
            if (!(EsNumero(txtMonto.Text)))
            { //invoca metodo EsNumero
                MessageBox.Show("Valor Monto incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus(); return; //finaliza ejecucion de este procedimiento
            }
            else
            {
                MontoInic = Convert. ToDouble(txtMonto.Text);
                if (!(MontoInic > 0))
                {
                    MessageBox.Show("Valor Monto no puede ser negativo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //metodo que indica que control txtEmpresa recibira cursor txtMonto.Focus();
                    return;
                }
            }
            //toma tiempo en años dado por usuario
            Tiempo = Convert.ToInt32(txtTiempo.Text);
            
            //si selecciono Tasa interes 3, valida que esta sea correcta
            txtTasaInterEX.Text = txtTasaInterEX.Text.Trim();
            if (rdbInteres3.Checked == true)
                if (txtTasaInterEX.Text.Length > 0)
                    if (!(EsNumero(txtTasaInterEX.Text) == true))
                    {
                        MessageBox.Show("Tasa interes incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); txtTasaInterEX.Text = "0"; txtTasaInterEX.Focus();
                        return;
                    }
                    else
                        TasaI = Convert.ToDouble(txtTasaInterEX.Text) / 100;
                else
                {
                    MessageBox.Show("Aun no ha indicado una tasa interes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information); txtTasaInterEX.Focus();
                    return;
                }
            //Hace el cálculo del monto de prestamo que pagara empresa
            MontoFin = 1 + TasaI;
            MontoFin = MontoInic * (Math.Pow(Convert.ToDouble (MontoFin), Tiempo));
            TasaI *= 100; //En cuadro de lista, muestra la respuesta (Monto a pagar)
            lstResul.Items.Clear();
            lstResul.Items.Add("Empresa: " + txtEmpresa.Text);
            lstResul.Items.Add("Monto: $" + MontoInic + ", Tasa anual: " + TasaI);
            lstResul.Items.Add("Monto a pagar: $" + MontoFin);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtEmpresa.Clear();
            txtMonto.Clear();
            txtTiempo.Text = "2";
            rdbInteres1.Checked = true;
            txtTasaInterEX.Clear();
            txtTasaInterEX.Enabled = false;
            lstResul.Items.Clear();
            txtEmpresa.Focus();
        }

        private void rdbInteres2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
