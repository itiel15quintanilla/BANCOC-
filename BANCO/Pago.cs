using System;
using System.Data;
using System.Data.SqlClient;

namespace BANCO
{

    public partial class Pago
    {
        private string connectionString = @"Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True";
        private SqlConnection connection;

        public Pago()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            // Cargar datos al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            // Cargar datos en el DataGridView
            string query = "SELECT * FROM Pago";
            var adapter = new SqlDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar un nuevo pago
            string query = "INSERT INTO Pago (id_pago, monto, id_tipo_movimiento) VALUES (@id_pago, @monto, @id_tipo_movimiento)";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id_pago", txtIdPago.Text);
                cmd.Parameters.AddWithValue("monto", txtMonto.Text);
                cmd.Parameters.AddWithValue("@id_tipo_movimiento", txtTipoMov.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de agregar
            LoadData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar un pago existente
            string query = "UPDATE Pago SET monto = @monto, id_tipo_movimiento = @id_tipo_movimiento WHERE id_pago = @id_pago";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("monto", txtMontoo.Text);
                cmd.Parameters.AddWithValue("@id_tipo_movimiento", txtTipoMovv.Text);
                cmd.Parameters.AddWithValue("@id_pago", DataGridView1.CurrentRow.Cells["id_pago"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de actualizar
            LoadData();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar un pago
            string query = "DELETE FROM Pago WHERE id_pago=@id_pago";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_pago", DataGridView1.CurrentRow.Cells["id_pago"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de eliminar
            LoadData();
        }
    }
}