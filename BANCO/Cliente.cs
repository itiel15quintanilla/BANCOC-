using System;
using System.Data;
using System.Data.SqlClient;

namespace BANCO
{

    public partial class Cliente
    {
        private string connectionString = @"Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True";
        private SqlConnection connection;

        public Cliente()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // Cargar datos al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            // Cargar datos en el DataGridView
            string query = "SELECT * FROM Cliente";
            var adapter = new SqlDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar un nuevo cliente
            string query = "INSERT INTO Cliente (id_cliente, nombre_c, ap_pat_c, ape_mat_c, direccion_c, ciudad_c, telefono_c, correo_c, id_sucursal) VALUES (@id_cliente, @nombre_c, @ap_pat_c, @ape_mat_c, @direccion_c, @ciudad_c, @telefono_c, @correo_c, @id_sucursal)";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id_cliente", txtIdCliente.Text);
                cmd.Parameters.AddWithValue("@nombre_c", txtNombre.Text);
                cmd.Parameters.AddWithValue("@ap_pat_c", TxtApPat.Text);
                cmd.Parameters.AddWithValue("@ape_mat_c", TxtApMat.Text);
                cmd.Parameters.AddWithValue("@direccion_c", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@ciudad_c", txtCiudad.Text);
                cmd.Parameters.AddWithValue("@telefono_c", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@correo_c", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@id_sucursal", txtIdSucursal.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de agregar
            LoadData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar un cliente existente
            string query = "UPDATE Cliente SET nombre_c = @nombre_c, ap_pat_c = @ap_pat_c, ape_mat_c = @ape_mat_c, direccion_c = @direccion_c, ciudad_c = @ciudad_c, telefono_c = @telefono_c, correo_c = @correo_c, id_sucursal = @id_sucursal WHERE id_cliente = @id_cliente";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@nombre_c", txtNombree.Text);
                cmd.Parameters.AddWithValue("@ap_pat_c", txtApPatt.Text);
                cmd.Parameters.AddWithValue("@ape_mat_c", txtApMatt.Text);
                cmd.Parameters.AddWithValue("@direccion_c", txtDireccionn.Text);
                cmd.Parameters.AddWithValue("@ciudad_c", txtCiudadd.Text);
                cmd.Parameters.AddWithValue("@telefono_c", txtTelefonoo.Text);
                cmd.Parameters.AddWithValue("@correo_c", txtCorreoo.Text);
                cmd.Parameters.AddWithValue("@id_sucursal", txtIdSucursal.Text);
                cmd.Parameters.AddWithValue("@id_cliente", DataGridView1.CurrentRow.Cells["id_cliente"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de actualizar
            LoadData();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar un cliente
            string query = "DELETE FROM Cliente WHERE id_cliente=@id_cliente";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_cliente", DataGridView1.CurrentRow.Cells["id_cliente"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de eliminar
            LoadData();
        }
    }
}