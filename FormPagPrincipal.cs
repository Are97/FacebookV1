using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using FacebookV1.SQLConnection;

namespace FacebookV1
{
    public partial class FormPagPrincipal : Form
    {
        private string contra = "";
        public string idpersona = "";
        public string nombre = "";
        public string correo = "";
        private static DataService _service;

        public FormPagPrincipal(string _idpersona, string _nombre, string _correo, string _contra)
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new DataService(connectionString);
            buttonPerfil.Text = _nombre;
            List<string> opciones = new List<string>() { "Opciones","Inicio", "Perfil", "Buscar amigos","Modificar perfil" };
            comboBoxOpciones.DataSource = opciones;
            textBoxNombreModificar.Text = _nombre;
            textBoxCorreoModificar.Text = _correo;
            contra = _contra;
            idpersona = _idpersona;
            nombre = _nombre;
            correo = _correo;
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
            switch (comboBoxOpciones.Text)
            {
                case "Modificar perfil":
                    pictureBoxModificar.Visible = true;
                    textBoxNombreModificar.Visible = true;
                    textBoxNombreModificar.BringToFront();
                    textBoxCorreoModificar.Visible = true;
                    textBoxCorreoModificar.BringToFront();
                    textBoxContraseñaModificar.Visible = true;
                    textBoxContraseñaModificar.BringToFront();
                    textBoxContraseñaNuevaModificar.Visible = true;
                    textBoxContraseñaNuevaModificar.BringToFront();
                    textBoxContraseñaConfModificar.Visible = true;
                    textBoxContraseñaConfModificar.BringToFront();
                    buttonAceptar.Visible = true;
                    buttonAceptar.BringToFront();
                    radioButtonCambiarContraseña.Visible = true;
                    radioButtonCambiarContraseña.BringToFront();

                    break;
                default:
                    MessageBox.Show(comboBoxOpciones.Text);
                    break;

            }
        }

        private void textBoxContraseñaModificar_Click(object sender, EventArgs e)
        {
            if (textBoxContraseñaModificar.Text == "Contraseña")
            {
                textBoxContraseñaModificar.Text = "";
                textBoxContraseñaModificar.ForeColor = System.Drawing.Color.Black;
                textBoxContraseñaModificar.UseSystemPasswordChar = true;
            }
        }

        private void textBoxContraseñaNuevaModificar_Click(object sender, EventArgs e)
        {
            if (textBoxContraseñaNuevaModificar.Text == "Contraseña")
            {
                textBoxContraseñaNuevaModificar.Text = "";
                textBoxContraseñaNuevaModificar.ForeColor = System.Drawing.Color.Black;
                textBoxContraseñaNuevaModificar.UseSystemPasswordChar = true;
            }
        }

        private void textBoxContraseñaConfModificar_Click(object sender, EventArgs e)
        {
            if (textBoxContraseñaConfModificar.Text == "Contraseña")
            {
                textBoxContraseñaConfModificar.Text = "";
                textBoxContraseñaConfModificar.ForeColor = System.Drawing.Color.Black;
                textBoxContraseñaConfModificar.UseSystemPasswordChar = true;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if(textBoxContraseñaModificar.Text == contra && textBoxContraseñaNuevaModificar.Text == textBoxContraseñaConfModificar.Text)
            {
                MessageBox.Show("Se cambiara la contra");
                
               // _service.UpdatePerfil(idpersona, nombre, correo, contra);
                if (_service.UpdatePerfil(idpersona, nombre, correo, contra))
                {
                    MessageBox.Show("True");
                }
                else
                {
                    MessageBox.Show("false");
                }
            }
            else
            {
                MessageBox.Show("No se cambiara la contra");
            }
        }
    }
}
