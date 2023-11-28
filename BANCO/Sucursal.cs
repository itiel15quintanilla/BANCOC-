using System;
using System.Data;
using System.Data.SqlClient;

namespace BANCO
{

    public partial class Sucursal
    {
        private string connectionString = @"Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True";
        private SqlConnection connection;

        public Sucursal()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void Sucursal_Load(object sender, EventArgs e)
        {
            // Cargar datos al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            // Cargar datos en el DataGridView
            string query = "SELECT * FROM Sucursal";
            var adapter = new SqlDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar una nueva sucursal
            string query = "INSERT INTO Sucursal (id_sucursal,nombre_s, direccion_s, ciudad_s, telefono_s, correo_s) VALUES (@id_sucursal, @nombre_s, @direccion_s, @ciudad_s, @telefono_s, @correo_s)";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id_sucursal", txtIdSucursal.Text);
                cmd.Parameters.AddWithValue("@nombre_s", txtNombre.Text);
                cmd.Parameters.AddWithValue("@direccion_s", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@ciudad_s", txtCiudad.Text);
                cmd.Parameters.AddWithValue("@telefono_s", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@correo_s", txtCorreo.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de agregar
            LoadData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar una sucursal existente
            string query = "UPDATE Sucursal SET nombre_s = @nombre_s, direccion_s = @direccion_s, ciudad_s = @ciudad_s, telefono_s = @telefono_s, correo_s = @correo_s WHERE id_sucursal = @id_sucursal";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@nombre_s", txtNombree.Text);
                cmd.Parameters.AddWithValue("@direccion_s", txtDireccionn.Text);
                cmd.Parameters.AddWithValue("@ciudad_s", txtCiudadd.Text);
                cmd.Parameters.AddWithValue("@telefono_s", txtTelefonoo.Text);
                cmd.Parameters.AddWithValue("@correo_s", txtCorreoo.Text);
                cmd.Parameters.AddWithValue("@id_sucursal", DataGridView1.CurrentRow.Cells["id_sucursal"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de actualizar
            LoadData();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar una sucursal
            string query = "DELETE FROM Sucursal WHERE id_sucursal=@id_sucursal";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_sucursal", DataGridView1.CurrentRow.Cells["id_sucursal"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de eliminar
            LoadData();

        }
    }
}