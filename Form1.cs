﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // *********************** BASURA ******************************//
        private void textBoxCorreoIS_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void buttonIS_MouseEnter(object sender, EventArgs e)
        {
        }
        private void textBoxContraseñaIS_TabIndexChanged(object sender, EventArgs e)
        {
        }
        //****************************** FIN BASURA ********************//

        private void textBoxCorreoIS_Click(object sender, EventArgs e)
        {
            if(textBoxCorreoIS.Text == "Correo electrónico")
            {
                textBoxCorreoIS.Text = "";
                textBoxCorreoIS.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxContraseñaIS_Click(object sender, EventArgs e)
        {
            if (textBoxContraseñaIS.Text == "Contraseña")
            {
                textBoxContraseñaIS.Text = "";
                textBoxContraseñaIS.ForeColor = System.Drawing.Color.Black;
                textBoxContraseñaIS.UseSystemPasswordChar = true;
            }
        }

        private void buttonIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciar Sesion");
        }

        private void buttonCuentaN_Click(object sender, EventArgs e)
        {
            FormRegistro fr = new FormRegistro();
            fr.Show();
        }

        
    }
}
