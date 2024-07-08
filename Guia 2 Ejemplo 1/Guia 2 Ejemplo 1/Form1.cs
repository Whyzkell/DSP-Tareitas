using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2_Ejemplo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            int numero;
            double suma, resta, mult, div;
            //Entrada de datos
            numero = Convert.ToInt32(txtnumero.Text);
            //Proceso
            //Dejamos en blanco lo combobox
            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomult.Items.Clear();
            cbodiv.Items.Clear();

            //Creamos nuestro bucle para poder mostrar la tabla del 1 al                 12

            for (int i = 1; i <= 12; i = i + 1)
            {
                suma = numero + i;
                resta = numero - i;
                mult = numero * i;
                div = numero / i;
                //Agregar los resultados a los combobox
                cbosuma.Items.Add(numero + " + " + i + " = " + suma);
                cboresta.Items.Add(numero + " - " + i + " = " + resta);
                cbomult.Items.Add(numero + " * " + i + " = " + mult);
                cbodiv.Items.Add(numero + " / " + i + " = " + div);

            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomult.Items.Clear();
            cbodiv.Items.Clear();
            txtnumero.Clear();
        }
    }
}
