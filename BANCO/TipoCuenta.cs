using System;
using System.Data;
using System.Data.SqlClient;

namespace BANCO
{

    public partial class TipoCuenta
    {
        private string connectionString = @"Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True";
        private SqlConnection connection;

        public TipoCuenta()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void TipoCuenta_Load(object sender, EventArgs e)
        {
            // Cargar datos al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            // Cargar datos en el DataGridView
            string query = "SELECT * FROM TipoCuenta";
            var adapter = new SqlDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar un nuevo tipo de cuenta
            string query = "INSERT INTO TipoCuenta (id_tipo_cuenta, tipo_cuenta) VALUES (@id_tipo_cuenta, @tipo_cuenta)";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id_tipo_cuenta", txtIdTipoCuenta.Text);
                cmd.Parameters.AddWithValue("@tipo_cuenta", txtTipoCuenta.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de agregar
            LoadData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar una cuenta existente
            string query = "UPDATE TipoCuenta SET tipo_cuenta = @tipo_cuenta WHERE id_tipo_cuenta = @id_tipo_cuenta";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@tipo_cuenta", txtTipoCuentaa.Text);
                cmd.Parameters.AddWithValue("@id_tipo_cuenta", DataGridView1.CurrentRow.Cells["id_tipo_cuenta"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de actualizar
            LoadData();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar un tipo de cuenta
            string query = "DELETE FROM TipoCuenta WHERE id_tipo_cuenta=@id_tipo_cuenta";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_tipo_cuenta", DataGridView1.CurrentRow.Cells["id_tipo_cuenta"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de eliminar
            LoadData();
        }
    }
}