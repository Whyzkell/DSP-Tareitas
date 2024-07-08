using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2_Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double num1 = (double)numNumber1.Value;
            double num2 = (double)numNumber2.Value;
            double num3 = (double)numNumber3.Value;
            double num4 = (double)numNumber4.Value;

            double sum = num1 + num2 + num3 + num4;
            double average = sum / 4;

            double squareSum = Math.Pow(num1 - average, 2) + Math.Pow(num2 - average, 2) + Math.Pow(num3 - average, 2) + Math.Pow(num4 - average, 2);
            double stdDev = Math.Sqrt(squareSum / 4);

            MessageBox.Show($"Promedio: {average:N2}\nDesviación típica: {stdDev:N2}");


        }
    }
}
