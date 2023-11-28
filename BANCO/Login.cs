using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BANCO
{

    public partial class Form1
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection(@"Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string consulta = "SELECT * FROM Usuario WHERE usuario = @usuario AND contrasena = @contrasena";
            comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@usuario", textBox1.Text);
            comando.Parameters.AddWithValue("@contrasena", textBox2.Text);

            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows)
            {
                My.MyProject.Forms.Tablas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }

            conexion.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Configura la propiedad PasswordChar para mostrar asteriscos
            textBox2.PasswordChar = '*';
        }
    }
}