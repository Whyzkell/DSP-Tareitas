using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10NumdecimalesCualquiera
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal numero = decimal.Parse(txtNumero.Text);

            if (numero > 0)
            {
                lstPositivos.Items.Add(numero);
            }
            else
            {
                lstNegativos.Items.Add(numero);
            }

            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            decimal menorNegativo = decimal.MaxValue;
            decimal sumaPositivos = 0;
            int conteoPositivos = 0;

            foreach (object item in lstNegativos.Items)
            {
                decimal numero = (decimal)item;
                if (numero < menorNegativo)
                {
                    menorNegativo = numero;
                }
            }

            foreach (object item in lstPositivos.Items)
            {
                decimal numero = (decimal)item;
                sumaPositivos += numero;
                conteoPositivos++;
            }

            decimal promedioPositivos = sumaPositivos / conteoPositivos;

            lstResultados.Items.Add("Menor número negativo: " + menorNegativo);
            lstResultados.Items.Add("Promedio de números positivos: " + promedioPositivos);

        }
    }
}
