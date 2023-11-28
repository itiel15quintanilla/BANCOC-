using System;
using System.Data;
using System.Data.SqlClient;

namespace BANCO
{

    public partial class Cuenta
    {
        private string connectionString = @"Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True";
        private SqlConnection connection;

        public Cuenta()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void Cuenta_Load(object sender, EventArgs e)
        {
            // Cargar datos al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            // Cargar datos en el DataGridView
            string query = "SELECT * FROM Cuenta";
            var adapter = new SqlDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar una nueva cuenta
            string query = "INSERT INTO Cuenta (id_cuenta ,fecha_apertura, id_cliente, id_tipo_cuenta) VALUES (@id_cuenta, @fecha_apertura, @id_cliente, @id_tipo_cuenta)";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id_cuenta", txtIdCuenta.Text);
                cmd.Parameters.AddWithValue("@fecha_apertura", txtFecha.Text);
                cmd.Parameters.AddWithValue("@id_cliente", txtIdCliente.Text);
                cmd.Parameters.AddWithValue("@id_tipo_cuenta", txtIdTipoCuenta.Text);
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
            string query = "UPDATE Cuenta SET fecha_apertura = @fecha_apertura, id_cliente = @id_cliente, id_tipo_cuenta = @id_tipo_cuenta WHERE id_cuenta = @id_cuenta";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fecha_apertura", txtFechaa.Text);
                cmd.Parameters.AddWithValue("@id_cliente", txtIdClientee.Text);
                cmd.Parameters.AddWithValue("@id_tipo_cuenta", txtIdTipoCuentaa.Text);
                cmd.Parameters.AddWithValue("@id_cuenta", DataGridView1.CurrentRow.Cells["id_cuenta"].Value);
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
            string query = "DELETE FROM Cuenta WHERE id_cuenta=@id_cuenta";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_cuenta", DataGridView1.CurrentRow.Cells["id_cuenta"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de eliminar
            LoadData();
        }
    }
}