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
            UseWaitCursor = true;
            string connectionString;
            connectionString = "Data Source=PABLOARELLANO\\SQLEXPRESS;initial catalog=facebook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            ReadOrderData(connectionString);
            UseWaitCursor = false;
        }
        private void ReadOrderData(string connectionString)
        {    
            string queryString =
                "select contras, idpersona, nombre, correo from persona where correo = '"+textBoxCorreoIS.Text+"'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                if (command.ExecuteScalar() != null)
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ReadSingleRow((IDataRecord)reader);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                }
                
            }
        }
        private void ReadSingleRow(IDataRecord record)
        {
            
            if (String.Format("{0}", record[0]) == textBoxContraseñaIS.Text)
            {
                FormPagPrincipal fpp = new FormPagPrincipal(String.Format("{0}", record[1]), String.Format("{0}", record[2]), String.Format("{0}", record[3]), String.Format("{0}", record[0]));
                this.Hide();
                fpp.Show();
            }
            else {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }
                
        }
      

        private void buttonCuentaN_Click(object sender, EventArgs e)
        {
            FormRegistro fr = new FormRegistro();
            fr.Show();
        }

        
    }
}
