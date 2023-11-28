using System;
using System.Data;
using System.Data.SqlClient;

namespace BANCO
{

    public partial class Credito
    {

        private string connectionString = @"Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True";
        private SqlConnection connection;

        public Credito()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void Credito_Load(object sender, EventArgs e)
        {
            // Cargar datos al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            // Cargar datos en el DataGridView
            string query = "SELECT * FROM Credito";
            var adapter = new SqlDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar un nuevo credito
            string query = "INSERT INTO Credito (id_credito , id_cliente, id_tipo_credito) VALUES (@id_credito, @id_cliente, @id_tipo_credito)";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id_credito", txtIdCredito.Text);
                cmd.Parameters.AddWithValue("@id_cliente", txtIdCliente.Text);
                cmd.Parameters.AddWithValue("@id_tipo_credito", txtIdTipoCredito.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de agregar
            LoadData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar un credito existente
            string query = "UPDATE Credito SET  id_cliente = @id_cliente, id_tipo_credito = @id_tipo_credito WHERE id_credito = @id_credito";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_cliente", txtIdClientee.Text);
                cmd.Parameters.AddWithValue("@id_tipo_credito", txtIdTipoCreditoo.Text);
                cmd.Parameters.AddWithValue("@id_credito", DataGridView1.CurrentRow.Cells["id_credito"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de actualizar
            LoadData();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar una cuenta
            string query = "DELETE FROM Credito WHERE id_credito=@id_credito";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_credito", DataGridView1.CurrentRow.Cells["id_credito"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de eliminar
            LoadData();
        }
    }
}