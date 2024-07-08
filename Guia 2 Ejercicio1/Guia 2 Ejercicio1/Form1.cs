﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2_Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int limit = (int)numLimit.Value;
            listBox1.Items.Clear();

            int prevPrev = 0;
            int prev = 1;
            int current = 1;

            while (current <= limit)
            {
                listBox1.Items.Add(current);
                prevPrev = prev;
                prev = current;
                current = prevPrev + prev;
            }
        }
    }
}
