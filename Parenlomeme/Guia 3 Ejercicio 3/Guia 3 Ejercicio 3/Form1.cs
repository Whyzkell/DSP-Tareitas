using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_3_Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int[,] notas = GenerarMatrizNotas();
            MostrarNotas(notas);
        }

        private int[,] GenerarMatrizNotas()
        {
            int filas = 6;
            int columnas = 5;
            int[,] notas = new int[filas, columnas];
            Random random = new Random();

            for (int fila = 0; fila < filas; fila++)
            {
                int asignaturas = random.Next(2, 6); // número de asignaturas entre 2 y 5
                for (int columna = 0; columna < asignaturas; columna++)
                {
                    notas[fila, columna] = random.Next(0, 101); // notas entre 0 y 100
                }
            }

            return notas;
        }

        private void MostrarNotas(int[,] notas)
        {
            dataGridView1.ColumnCount = notas.GetLength(1) + 2; // +2 para la columna de media
            dataGridView1.RowCount = notas.GetLength(0);

            for (int fila = 0; fila < notas.GetLength(0); fila++)
            {
                dataGridView1[0, fila].Value = "Alumno " + (fila + 1);
                int asignaturas = 0;
                double suma = 0;
                for (int columna = 0; columna < notas.GetLength(1); columna++)
                {
                    if (notas[fila, columna] != 0)
                    {
                        asignaturas++;
                        suma += notas[fila, columna];
                        dataGridView1[columna + 1, fila].Value = notas[fila, columna].ToString();
                    }
                }
                if (asignaturas > 0)
                {
                    dataGridView1[notas.GetLength(1) + 1, fila].Value = (suma / asignaturas).ToString();
                }
            }

            dataGridView1.Columns[0].HeaderText = "Alumno";
            for (int i = 1; i < notas.GetLength(1) + 1; i++)
            {
                dataGridView1.Columns[i].HeaderText = "Asignatura " + i;
            }
            dataGridView1.Columns[notas.GetLength(1) + 1].HeaderText = "Media";
        }
    }
}
