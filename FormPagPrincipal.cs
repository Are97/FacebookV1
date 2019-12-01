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
    public partial class FormPagPrincipal : Form
    {
        public FormPagPrincipal(string idpersona, string nombre)
        {
            InitializeComponent();
            buttonPerfil.Text = nombre;
            List<string> opciones = new List<string>() { "Opciones","Inicio", "Perfil", "Buscar amigos" };
            comboBoxOpciones.DataSource = opciones;
        }

        private void textBoxBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text == "Buscar")
            {
                textBoxBuscar.Text = "";
                textBoxBuscar.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perfil");
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inicio");
        }

        private void textBoxBuscar_Enter(object sender, EventArgs e)
        {
            
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscar");
        }

        private void buttonIr_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(comboBoxOpciones.Text);
        }
    }
}
