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
using FacebookV1.CadenaResponsabilidad.Chain;
using FacebookV1.CadenaResponsabilidad;
using System.Data.SqlClient;
using FacebookV1.Prototype;
using FacebookV1.Memento;

namespace FacebookV1
{
    public partial class FormPagPrincipal : Form
    {
        private string contra = "";
        public string idpersona = "";
        public string nombre = "";
        public string correo = "";
        public string apellido = "";
        private static DataService _service;

        //Memento
        Caretaker caretaker = new Caretaker();
        Originator orig = new Originator();

        //Chain of Responsability
        EncargadoBuscarAmigos EBA = new EncargadoBuscarAmigos();
        EncargadoCerrarSesion ECS = new EncargadoCerrarSesion();
        EncargadoInicio EI = new EncargadoInicio();
        EncargadoModificarPerfil EMP = new EncargadoModificarPerfil();
        EncargadoPerfil EP = new EncargadoPerfil();
        EncargadoOpciones EO = new EncargadoOpciones();

        public FormPagPrincipal(string _idpersona, string _nombre, string _correo, string _contra, string _apellido)
        {
            InitializeComponent();
            //Chain of responsability Successors
            EBA.setSuccessor(ECS);
            ECS.setSuccessor(EI);
            EI.setSuccessor(EMP);
            EMP.setSuccessor(EP);
            EP.setSuccessor(EO);


            contra = _contra;
            idpersona = _idpersona;
            nombre = _nombre;
            correo = _correo;
            apellido = _apellido;

            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new DataService(connectionString);
            List<string> opciones = new List<string>() { "Opciones","Inicio", "Perfil", "BuscarAmigos","ModificarPerfil" ,"CerrarSesión"};
            comboBoxOpciones.DataSource = opciones;
            textBoxNombreModificar.Text = _nombre;
            textBoxCorreoModificar.Text = _correo;
            buttonPerfil.Text = nombre;
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
            buttonReset.Visible = false;

            if (labelNombre1.Text != "")
            {
                labelNombre1.Visible = true;
                labelComentarios1.Visible = true;
                labelMeGusta1.Visible = true;
                buttonMeGusta1.Visible = true;
                buttonComentar1.Visible = true;
                pictureBoxImg1.Visible = true;
                textBoxPost1.Visible = true;
                buttonLikes1.Visible = true;
                buttonComments1.Visible = true;
            }
            if(labelNombre2.Text != "")
            {
                labelNombre2.Visible = true;
                labelComentarios2.Visible = true;
                labelMeGusta2.Visible = true;
                buttonMeGusta2.Visible = true;
                buttonComentar2.Visible = true;
                pictureBoxImg2.Visible = true;
                textBoxPost2.Visible = true;
                buttonLikes2.Visible = true;
                buttonComments2.Visible = true;
            }
            

            buttonAceptarPost.Visible = true;
            buttonAceptarPost.BringToFront();
            pictureBoxPublicar.Visible = true;
            textBox1.Visible = true;
            textBox1.BringToFront();
            textBox1.ForeColor = System.Drawing.Color.Gray;
            textBox1.Text = "¿Qué estás pensando, " + nombre + "?";
            buttonPerfil.Text = nombre;
        }
        //Basura
        private void textBoxBuscar_Enter(object sender, EventArgs e)
        {
            
        }
        //Fin Basura
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscar");
        }

        private void buttonIr_Click(object sender, EventArgs e)
        {   
            Request request = new Request(comboBoxOpciones.Text);
            EBA.handleRequest(request);
            int res;
            res = request.GetNum();
            switch (res)
            {
                case 1: //ModificarPerfil
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
                    buttonReset.Visible = true;
                    buttonReset.BringToFront();

                    labelNombre1.Visible = false;
                    labelNombre2.Visible = false;
                    labelComentarios1.Visible = false;
                    labelComentarios2.Visible = false;
                    labelMeGusta1.Visible = false;
                    labelMeGusta2.Visible = false;
                    buttonMeGusta1.Visible = false;
                    buttonMeGusta2.Visible = false;
                    buttonComentar1.Visible = false;
                    buttonComentar2.Visible = false;
                    pictureBoxImg1.Visible = false;
                    pictureBoxImg2.Visible = false;
                    textBoxPost1.Visible = false;
                    textBoxPost2.Visible = false;
                    buttonLikes1.Visible = false;
                    buttonLikes2.Visible = false;
                    buttonComments1.Visible = false;
                    buttonComments2.Visible = false;

                    buttonAceptarPost.Visible = false;
                    textBox1.Visible = false;
                    pictureBoxPublicar.Visible = false;
                    buttonAceptar.Visible = true;
                    buttonAceptar.BringToFront();
                    pictureBoxNohacercaso.Visible = true;

                    //Memento
                    orig.setNombre(textBoxNombreModificar.Text);
                    orig.setCorreo(textBoxCorreoModificar.Text);
                    caretaker.save(orig);
                    break;
                case 2: //Cerrar sesion
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                    break;
                case 3: //Inicio
                    buttonInicio_Click(sender, e);
                    break;
                case 4: //Perfil
                    buttonPerfil_Click(sender, e);
                    break;
                case 5://Buscar Amigos
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
            //Memento
            orig.setNombre(textBoxNombreModificar.Text);
            orig.setCorreo(textBoxCorreoModificar.Text);
            caretaker.save(orig);
            if (textBoxContraseñaModificar.Text == contra && textBoxContraseñaNuevaModificar.Text == textBoxContraseñaConfModificar.Text)
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
            if(_service.Postear(idpersona, textBox1.Text, ""))
            {
                if(labelNombre1.Text == "")
                {
                    labelNombre1.Text = nombre + " " + apellido;
                    textBoxPost1.Text = textBox1.Text;
                    buttonInicio_Click(sender, e);
                }
                else
                {
                    Post post = new Post();
                    post.nombre = labelNombre1.Text;
                    post.post = textBoxPost1.Text;

                    Post post2 = post.Clone();
                    labelNombre2.Text = post2.nombre;
                    textBoxPost2.Text = post2.post;

                    labelNombre1.Text = nombre + " " + apellido;
                    textBoxPost1.Text = textBox1.Text;
                    buttonInicio_Click(sender, e);
                }                
            }
            else
            {
                MessageBox.Show("Error de conexion, \nvuelva a intentarlo");
            }
        }

        private void labelMeGusta_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //Memento
            if(caretaker.mementoHistory.Count() > 0)
            {
                caretaker.revert(orig);
                textBoxNombreModificar.Text = orig.getNombre();
                textBoxCorreoModificar.Text = orig.getCorreo();
                textBoxContraseñaModificar.UseSystemPasswordChar = false;
                textBoxContraseñaModificar.ForeColor = System.Drawing.Color.Gray;
                textBoxContraseñaModificar.Text = "Contraseña";
                textBoxContraseñaNuevaModificar.UseSystemPasswordChar = false;
                textBoxContraseñaNuevaModificar.ForeColor = System.Drawing.Color.Gray;
                textBoxContraseñaNuevaModificar.Text = "Contraseña";
                textBoxContraseñaConfModificar.UseSystemPasswordChar = false;
                textBoxContraseñaConfModificar.ForeColor = System.Drawing.Color.Gray;
                textBoxContraseñaConfModificar.Text = "Contraseña";
            }
        }
    }
}
