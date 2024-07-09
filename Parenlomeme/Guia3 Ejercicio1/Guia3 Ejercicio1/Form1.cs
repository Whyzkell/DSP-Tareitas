using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia3_Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = listaDeNombres;
        }

        private List<string> listaDeNombres = new List<string>();

        
        
           
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                listaDeNombres.Add(nombre);
                listBox1.DataSource = null;
                listBox1.DataSource = listaDeNombres;
                txtNombre.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ingrese un nombre válido");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listaDeNombres.Remove((string)listBox1.SelectedItem);
                listBox1.DataSource = null;
                listBox1.DataSource = listaDeNombres;
            }
            else
            {
                MessageBox.Show("Seleccione un nombre para borrar");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string nombreOriginal = (string)listBox1.SelectedItem;
                string nombreNuevo = txtNombre.Text.Trim();
                if (!string.IsNullOrEmpty(nombreNuevo))
                {
                    int indice = listaDeNombres.IndexOf(nombreOriginal);
                    listaDeNombres[indice] = nombreNuevo;
                    listBox1.DataSource = null;
                    listBox1.DataSource = listaDeNombres;
                    txtNombre.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre válido para modificar");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un nombre para modificar");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
