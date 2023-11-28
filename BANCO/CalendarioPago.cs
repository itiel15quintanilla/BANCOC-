using System;
using System.Data;
using System.Data.SqlClient;

namespace BANCO
{

    public partial class CalendarioPago
    {
        private string connectionString = @"Data Source=LAPTOP-M9JG8B6B\SQLEXPRESS02; Initial Catalog=BANCO; Integrated Security=True";
        private SqlConnection connection;

        public CalendarioPago()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void CalendarioPago_Load(object sender, EventArgs e)
        {
            // Cargar datos al iniciar el formulario
            LoadData();
        }

        private void LoadData()
        {
            // Cargar datos en el DataGridView
            string query = "SELECT * FROM CalendarioPago";
            var adapter = new SqlDataAdapter(query, connection);
            var table = new DataTable();
            adapter.Fill(table);
            DataGridView1.DataSource = table;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar un nuevo calendario
            string query = "INSERT INTO CalendarioPago (id_cal_pago ,fecha_pago, id_credito) VALUES (@id_cal_pago, @fecha_pago, @id_credito)";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id_cal_pago", txtIdCalendario.Text);
                cmd.Parameters.AddWithValue("@fecha_pago", txtFecha.Text);
                cmd.Parameters.AddWithValue("@id_credito", txtIdCredito.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de agregar
            LoadData();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar un calendario existente
            string query = "UPDATE CalendarioPago SET fecha_pago = @fecha_pago, id_credito = @id_credito WHERE id_cal_pago = @id_cal_pago";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fecha_pago", txtFechaa.Text);
                cmd.Parameters.AddWithValue("@id_credito", txtIdCreditoo.Text);
                cmd.Parameters.AddWithValue("@id_cal_pago", DataGridView1.CurrentRow.Cells["id_cal_pago"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de actualizar
            LoadData();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar un calendario 
            string query = "DELETE FROM CalendarioPago WHERE id_cal_pago=@id_cal_pago";
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_cal_pago", DataGridView1.CurrentRow.Cells["id_cal_pago"].Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar datos después de eliminar
            LoadData();
        }
    }
}