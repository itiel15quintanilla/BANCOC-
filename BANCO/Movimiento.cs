using System;
using System.Data;
using System.Data.SqlClient;

namespace BANCO
{

    public partial class Movimiento
    {
        private string connectionString = @"Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True";
        private SqlConnection connection;

        public Movimiento()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }


        private void Movimiento_Load(object sender, EventArgs e)
        {
            // Cargar datos al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            // Cargar datos en el DataGridView
            string query = "SELECT * FROM Movimiento";
            var adapter = new SqlDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar un nuevo movimiento 
            string query = "INSERT INTO Movimiento (id_movimiento ,fecha_movimiento, importe_movimiento, id_tipo_movimiento, id_cuenta) VALUES (@id_movimiento, @fecha_movimiento, @importe_movimiento, @id_tipo_movimiento, @id_cuenta)";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id_movimiento", txtIdMov.Text);
                cmd.Parameters.AddWithValue("@fecha_movimiento", txtFecha.Text);
                cmd.Parameters.AddWithValue("@importe_movimiento", txtImporte.Text);
                cmd.Parameters.AddWithValue("@id_tipo_movimiento", txtIdTipoMov.Text);
                cmd.Parameters.AddWithValue("@id_cuenta", txtIdCuenta.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de agregar
            LoadData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar un movimiento existente
            string query = "UPDATE Movimiento SET fecha_movimiento = @fecha_movimiento, importe_movimiento = @importe_movimiento, id_tipo_movimiento = @id_tipo_movimiento, id_cuenta = @id_cuenta WHERE id_movimiento = @id_movimiento";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fecha_movimiento", txtFechaa.Text);
                cmd.Parameters.AddWithValue("@importe_movimiento", txtImportee.Text);
                cmd.Parameters.AddWithValue("@id_tipo_movimiento", txtIdTipoMovv.Text);
                cmd.Parameters.AddWithValue("@id_cuenta", TxtIdCuentaa.Text);
                cmd.Parameters.AddWithValue("@id_movimiento", DataGridView1.CurrentRow.Cells["id_movimiento"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de actualizar
            LoadData();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar un movimiento 
            string query = "DELETE FROM Movimiento WHERE id_movimiento=@id_movimiento";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_movimiento", DataGridView1.CurrentRow.Cells["id_movimiento"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de eliminar
            LoadData();
        }
    }
}