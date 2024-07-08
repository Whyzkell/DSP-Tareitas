using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2_Ejercicio_3
{
    public partial class wasasin : Form
    {
        public wasasin()
        {
            InitializeComponent();
        }

        private int[] numeros = new int[0];
        private int mayorNegativo = -40;
        private int positivos = 0;
        private int negativos = 0;
        private int ceros = 0;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(txtNumero.Text, out numero) && numero >= -40 && numero <= 45)
            {
                Array.Resize(ref numeros, numeros.Length + 1);
                numeros[numeros.Length - 1] = numero;

                if (numero < 0)
                {
                    if (numero > mayorNegativo)
                    {
                        mayorNegativo = numero;
                    }
                    negativos++;
                }
                else if (numero > 0)
                {
                    positivos++;
                }
                else
                {
                    ceros++;
                }

                lblMayorNegativo.Text = $"Mayor número negativo: {mayorNegativo}";
                lblPositivos.Text = $"Números positivos: {positivos}";
                lblPromedioNegativos.Text = $"Promedio de negativos: {(negativos > 0 ? (double)negativos / numeros.Length : 0):F2}";
                lblPorcentaje.Text = $"Porcentaje: Positivos {((double)positivos / numeros.Length) * 100:F2}%, Negativos {((double)negativos / numeros.Length) * 100:F2}%, Ceros {((double)ceros / numeros.Length) * 100:F2}%";

                txtNumero.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un número entero entre -40 y 45");
            }
        }
    
    }
}
