using System;
using System.Data;
using System.Data.SqlClient;

namespace BANCO
{

    public partial class TipoCredito
    {
        private string connectionString = @"Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True";
        private SqlConnection connection;

        public TipoCredito()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void TipoCredito_Load(object sender, EventArgs e)
        {
            // Cargar datos al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            // Cargar datos en el DataGridView
            string query = "SELECT * FROM TipoCredito";
            var adapter = new SqlDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar un nuevo tipo de credito
            string query = "INSERT INTO TipoCredito (id_tipo_credito, tipo_credito) VALUES (@id_tipo_credito, @tipo_credito)";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id_tipo_credito", txtIdTipoCredito.Text);
                cmd.Parameters.AddWithValue("@tipo_credito", txtTipoCredito.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de agregar
            LoadData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar un tipo de credito existente
            string query = "UPDATE TipoCredito SET tipo_credito = @tipo_credito WHERE id_tipo_credito = @id_tipo_credito";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@tipo_credito", txtTipoCreditoo.Text);
                cmd.Parameters.AddWithValue("@id_tipo_credito", DataGridView1.CurrentRow.Cells["id_tipo_credito"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de actualizar
            LoadData();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar un tipo de credito
            string query = "DELETE FROM TipoCredito WHERE id_tipo_credito=@id_tipo_credito";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_tipo_credito", DataGridView1.CurrentRow.Cells["id_tipo_credito"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de eliminar
            LoadData();
        }
    }
}