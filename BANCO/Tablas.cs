using System;

namespace BANCO
{
    public partial class Tablas{
        public Tablas()
        {
            InitializeComponent();
        }

        private void BtnSucursal_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Sucursal.ShowDialog();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cliente.ShowDialog();
        }

        private void BtnCuenta_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cuenta.ShowDialog();
        }

        private void BtnTipoCuena_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.TipoCuenta.ShowDialog();
        }

        private void BtnMov_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Movimiento.ShowDialog();
        }

        private void BtnTipoMov_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.TipoMovimiento.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Credito.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.TipoCredito.ShowDialog();
        }

        private void BtnCalPago_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CalendarioPago.ShowDialog();
        }

        private void BtnPago_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Pago.ShowDialog();
        }

        private void Tablas_Load(object sender, EventArgs e)
        {

        }
    }
}