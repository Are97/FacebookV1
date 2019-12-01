//using FacebookV1.SQLConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FacebookV1
{
    public partial class FormRegistro : Form
    {

        public FormRegistro()
        {
            InitializeComponent();
            List<int> dias = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            List<string> meses = new List<string>() { "ene", "feb", "mar", "abr", "may", "jun", "jul", "ago", "sep", "oct", "nov", "dic" };
            List<int> años = new List<int>() { 2019, 2018, 2017, 2016, 2015, 2014, 2013, 2012, 2011, 2010, 2009, 2008, 2007, 2006, 2005, 2004, 2003, 2002, 2001, 2000, 1999, 1998, 1997, 1996, 1995, 1994, 1993, 1992, 1991, 1990, 1989, 1988, 1987, 1986, 1985, 1984, 1983, 1982, 1981, 1980 };
            comboBoxDia.DataSource = dias;
            comboBoxMes.DataSource = meses;
            comboBoxAño.DataSource = años;
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
            UseWaitCursor = true;
            //Una conexion a BD un poco mala...
            string connectionString;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql =
                "insert into persona values ('" + textBoxCorreoIS.Text + "','" + textBoxApellido.Text + "','" + textBoxCorreo.Text + "','" + textBoxContraseñaN.Text + "'," + comboBoxDia.Text + ",'" + comboBoxMes.Text + "'," + comboBoxAño.Text + "," + (radioButtonMujer.Checked ? 0 : 1) + ")";
                
            connectionString = connectionString = "Data Source=PABLOARELLANO\\SQLEXPRESS;initial catalog=facebook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
            UseWaitCursor = false;
            MessageBox.Show("Registro Correcto");
            this.Close();
        }

        private void radioButtonHombre_Click(object sender, EventArgs e)
        {
            if (radioButtonMujer.Checked)
            {
                radioButtonMujer.Checked = false;
            }
        }

        private void radioButtonMujer_Click(object sender, EventArgs e)
        {
            if (radioButtonHombre.Checked)
            {
                radioButtonHombre.Checked = false;
            }
        }
    }
}
