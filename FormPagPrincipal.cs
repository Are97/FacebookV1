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
            List<string> opciones = new List<string>() { "Opciones","Inicio", "Perfil", "Buscar amigos","Modificar perfil" ,"Cerrar sesión"};
            comboBoxOpciones.DataSource = opciones;
            textBoxNombreModificar.Text = _nombre;
            textBoxCorreoModificar.Text = _correo;
            contra = _contra;
            idpersona = _idpersona;
            nombre = _nombre;
            correo = _correo;
            textBox1.Text = "¿Qué estás pensando, " + nombre + "?";
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
            pictureBoxModificar.Visible = false;
            textBoxNombreModificar.Visible = false;
            textBoxCorreoModificar.Visible = false;
            textBoxContraseñaModificar.Visible = false;
            textBoxContraseñaNuevaModificar.Visible = false;
            textBoxContraseñaConfModificar.Visible = false;
            buttonAceptar.Visible = false;
            pictureBoxNohacercaso.Visible = false;

            buttonAceptarPost.Visible = true;
            buttonAceptarPost.BringToFront();
            pictureBoxPublicar.Visible = true;
            textBox1.Visible = true;
            textBox1.BringToFront();
            textBox1.ForeColor = System.Drawing.Color.Gray;
            textBox1.Text = "¿Qué estás pensando, " + nombre + "?";
            buttonPerfil.Text = nombre;
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

                    buttonAceptarPost.Visible = false;
                    textBox1.Visible = false;
                    pictureBoxPublicar.Visible = false;
                    buttonAceptar.Visible = true;
                    buttonAceptar.BringToFront();
                    pictureBoxNohacercaso.Visible = true;
                    break;
                case "Cerrar sesión":
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                    break;
                case "Inicio":
                    buttonInicio_Click(sender, e);
                    break;
                case "Perfil":
                    buttonPerfil_Click(sender, e);
                    break;
                case "Buscar amigos":
                    buttonBuscar_Click(sender, e);
                    break;
                default:
                    MessageBox.Show("Opción no válida");
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
                if (_service.UpdatePerfil(idpersona, textBoxNombreModificar.Text, textBoxCorreoModificar.Text, textBoxContraseñaNuevaModificar.Text))
                {
                    nombre = textBoxNombreModificar.Text;
                    correo = textBoxCorreoModificar.Text;
                    contra = textBoxContraseñaNuevaModificar.Text;
                    buttonInicio_Click(sender,e);
                }
                else
                {
                    MessageBox.Show("Problemas al modificar tu perfil");
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void FormPagPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "¿Qué estás pensando, " + nombre + "?")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void buttonAceptarPost_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Me gusta tu post!");
            textBox1.ForeColor = System.Drawing.Color.Gray;
            textBox1.Text = "¿Qué estás pensando, " + nombre + "?";
        }
    }
}
