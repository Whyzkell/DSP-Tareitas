using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_3_Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int dimension;
            if (int.TryParse(txtDimension.Text, out dimension) && dimension > 0)
            {
                int[,] matriz = GenerarMatrizCuadrada(dimension);
                MostrarMatriz("Matriz original", matriz, dataGridView1);

                int[,] traspuesta = CalcularTraspuesta(matriz);
                MostrarMatriz("Matriz traspuesta", traspuesta, dataGridView2);
            }
            else
            {
                MessageBox.Show("Ingrese una dimensión válida");
            }
        }

        private int[,] GenerarMatrizCuadrada(int dimension)
        {
            int[,] matriz = new int[dimension, dimension];
            Random random = new Random();

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matriz[i, j] = random.Next(1, 101); // números aleatorios entre 1 y 100
                }
            }

            return matriz;
        }

        private int[,] CalcularTraspuesta(int[,] matriz)
        {
            int dimension = matriz.GetLength(0);
            int[,] traspuesta = new int[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    traspuesta[j, i] = matriz[i, j];
                }
            }

            return traspuesta;
        }

        private void MostrarMatriz(string titulo, int[,] matriz, DataGridView dataGridView)
        {
            dataGridView.ColumnCount = matriz.GetLength(0);
            dataGridView.RowCount = matriz.GetLength(0);

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    dataGridView[j, i].Value = matriz[i, j].ToString();
                }
            }

            dataGridView.Columns[0].HeaderText = titulo;
        }
    }
}
