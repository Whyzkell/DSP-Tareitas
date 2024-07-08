using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo3_Vladi
{

    public partial class Form1 : Form
    {

        static string EvaluarDesempeno(char Nota)
        {
            string res = "";
            switch (Nota)
            {
                case 'a':
                case 'A':
                    res = "Excelente, aprobado con honores";
                    break;
                case 'b':
                case 'B':
                    res = "Aprobado de forma sobresaliente";
                    break;
                case 'c':
                case 'C':
                    res = "Aprobado con buen desempeño";
                    break;
                case 'd':
                case 'D':
                    res = "Aprobado de manera regular";
                    break;
                case 'e':
                case 'E':
                    res = "Aprobado, pero se sugiere mejorar";
                    break;
                case 'f':
                case 'F':
                    res = "Reprobado, con rendimiento pobre";
                    break;
                default:
                    res = "Nota incorrecta";
                    break;
            }
            return res;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void txtCalif_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicacion finalizar ahora",
                "App Evaluacion Academica", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void txtCalif_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            //obtiene copia de tecla presionada por usuario
            char tecla = e.KeyChar;
            tecla = Char.ToUpper(tecla);
            if (tecla >= 'A' && tecla <= 'F')
                txtCalif.Text = tecla.ToString();
            else
                txtCalif.Text = "(A hasta F)";
            lblResul.Text = EvaluarDesempeno(tecla);
        }
    }
}
