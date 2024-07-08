using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2_Ejemplo3_DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            int cantAlumnos, nota;
            Double promedio = 0;
            //Entrada de datos
            cantAlumnos = Convert.ToInt32(txtCantAlumnos.Text);
            //proceso
            //Implementamos el bucle
            for (int i = 1; i <= cantAlumnos; i++)
            {
                do
                {
                    //Leer la nota con un inputbox
                    //Agregar la referencia para utilizar el input box
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la Nota del alumno " + i, "Notas"));
                } while (nota <= 0 || nota >= 20);
                promedio = promedio + nota;
            }
            //Salida de información
            txtPromedio.Text = Convert.ToString(promedio);

        

    }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCantAlumnos.Clear();
            txtPromedio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
