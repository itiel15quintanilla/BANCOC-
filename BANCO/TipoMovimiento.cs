using System;
using System.Data;
using System.Data.SqlClient;

namespace BANCO
{

    public partial class TipoMovimiento
    {
        private string connectionString = @"Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True";
        private SqlConnection connection;

        public TipoMovimiento()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void TipoMovimiento_Load(object sender, EventArgs e)
        {
            // Cargar datos al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            // Cargar datos en el DataGridView
            string query = "SELECT * FROM TipoMovimiento";
            var adapter = new SqlDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar un nuevo tipo de movimiento
            string query = "INSERT INTO TipoMovimiento (id_tipo_movimiento, tipo_movimiento) VALUES (@id_tipo_movimiento, @tipo_movimiento)";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id_tipo_movimiento", txtIdTipoMov.Text);
                cmd.Parameters.AddWithValue("@tipo_movimiento", txtTipoMov.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de agregar
            LoadData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar un tipo de movimiento existente
            string query = "UPDATE TipoCuenta SET tipo_movimiento = @tipo_movimineto WHERE id_tipo_movimiento = @id_tipo_movimiento";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@tipo_movimiento", txtTipoMovv.Text);
                cmd.Parameters.AddWithValue("@id_tipo_movimiento", DataGridView1.CurrentRow.Cells["id_tipo_movimiento"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de actualizar
            LoadData();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar un tipo de movimiento
            string query = "DELETE FROM TipoMovimiento WHERE id_tipo_movimiento=@id_tipo_movimiento";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_tipo_movimiento", DataGridView1.CurrentRow.Cells["id_tipo_movimiento"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de eliminar
            LoadData();
        }
    }
}