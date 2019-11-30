using System;
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
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void textBoxCorreoIS_Click(object sender, EventArgs e)
        {
            if (textBoxCorreoIS.Text == "Nombre")
            {
                textBoxCorreoIS.Text = "";
                textBoxCorreoIS.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxApellido_Click(object sender, EventArgs e)
        {
            if (textBoxApellido.Text == "Apellido")
            {
                textBoxApellido.Text = "";
                textBoxApellido.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxCorreo_Click(object sender, EventArgs e)
        {
            if (textBoxCorreo.Text == "Correo electrónico")
            {
                textBoxCorreo.Text = "";
                textBoxCorreo.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxContraseñaN_Click(object sender, EventArgs e)
        {
            if (textBoxContraseñaN.Text == "Contraseña nueva")
            {
                textBoxContraseñaN.Text = "";
                textBoxContraseñaN.ForeColor = System.Drawing.Color.Black;
                textBoxContraseñaN.UseSystemPasswordChar = true;
            }
        }

        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrate");
        }
    }
}
