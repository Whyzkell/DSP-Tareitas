using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fecha
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mes = int.Parse(cmbMes.SelectedItem.ToString());
            int dia = int.Parse(cmbDia.SelectedItem.ToString());
            int ano = int.Parse(cmbAno.SelectedItem.ToString());

            if (!IsValidDate(mes, dia, ano))
            {
                MessageBox.Show(GetErrorMessage(mes, dia, ano));
            }
        }



        private bool IsValidDate(int mes, int dia, int ano)
        {
            switch (mes)
            {
                case 1: // Enero
                case 3: // Marzo
                case 5: // Mayo
                case 7: // Julio
                case 8: // Agosto
                case 10: // Octubre
                case 12: // Diciembre
                    return dia <= 31;
                case 2: // Febrero
                    if (IsLeapYear(ano))
                        return dia <= 29;
                    else
                        return dia <= 28;
                case 4: // Abril
                case 6: // Junio
                case 9: // Septiembre
                case 11: // Noviembre
                    return dia <= 30;
                default:
                    return false;
            }
        }

        private bool IsLeapYear(int ano)
        {
            return (ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0;
        }

        private string GetErrorMessage(int mes, int dia, int ano)
        {
            switch (mes)
            {
                case 1: // Enero
                case 3: // Marzo
                case 5: // Mayo
                case 7: // Julio
                case 8: // Agosto
                case 10: // Octubre
                case 12: // Diciembre
                    return "El día debe ser menor o igual a 31";
                case 2: // Febrero
                    if (IsLeapYear(ano))
                        return "El día debe ser menor o igual a 29";
                    else
                        return "El día debe ser menor o igual a 28";
                case 4: // Abril
                case 6: // Junio
                case 9: // Septiembre
                case 11: // Noviembre
                    return "El día debe ser menor o igual a 30";
                default:
                    return "Fecha inválida";
            }
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mes = int.Parse(cmbMes.SelectedItem.ToString());
            int dia = int.Parse(cmbDia.SelectedItem.ToString());
            int ano = int.Parse(cmbAno.SelectedItem.ToString());

            if (!IsValidDate(mes, dia, ano))
            {
                MessageBox.Show(GetErrorMessage(mes, dia, ano));
            }
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mes = int.Parse(cmbMes.SelectedItem.ToString());
            int dia = int.Parse(cmbDia.SelectedItem.ToString());
            int ano = int.Parse(cmbAno.SelectedItem.ToString());

            if (!IsValidDate(mes, dia, ano))
            {
                MessageBox.Show(GetErrorMessage(mes, dia, ano));
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            int mes = int.Parse(cmbMes.SelectedItem.ToString());
            int dia = int.Parse(cmbDia.SelectedItem.ToString());
            int ano = int.Parse(cmbAno.SelectedItem.ToString());

            if (IsValidDate(mes, dia, ano))
            {
                // La fecha es válida, puedes procesarla aquí
                MessageBox.Show("La fecha es válida");
            }
            else
            {
                // La fecha no es válida, muestra un mensaje de error
                MessageBox.Show(GetErrorMessage(mes, dia, ano));
            }
        }
    }
}
