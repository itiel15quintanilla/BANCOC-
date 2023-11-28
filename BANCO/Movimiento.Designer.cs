using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Movimiento : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            DataGridView1 = new DataGridView();
            txtIdTipoMovv = new TextBox();
            txtImportee = new TextBox();
            txtFechaa = new TextBox();
            Label9 = new Label();
            Label10 = new Label();
            Label12 = new Label();
            txtIdMov = new TextBox();
            Label11 = new Label();
            txtIdTipoMov = new TextBox();
            txtImporte = new TextBox();
            txtFecha = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            BtnEliminar = new Button();
            BtnEliminar.Click += new EventHandler(BtnEliminar_Click);
            BtnActualizar = new Button();
            BtnActualizar.Click += new EventHandler(BtnActualizar_Click);
            BtnAgregar = new Button();
            BtnAgregar.Click += new EventHandler(BtnAgregar_Click);
            txtIdCuenta = new TextBox();
            Label4 = new Label();
            TxtIdCuentaa = new TextBox();
            Label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(12, 12);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(694, 271);
            DataGridView1.TabIndex = 0;
            // 
            // txtIdTipoMovv
            // 
            txtIdTipoMovv.Location = new Point(445, 436);
            txtIdTipoMovv.Name = "txtIdTipoMovv";
            txtIdTipoMovv.Size = new Size(149, 22);
            txtIdTipoMovv.TabIndex = 81;
            // 
            // txtImportee
            // 
            txtImportee.Location = new Point(445, 398);
            txtImportee.Name = "txtImportee";
            txtImportee.Size = new Size(149, 22);
            txtImportee.TabIndex = 80;
            // 
            // txtFechaa
            // 
            txtFechaa.Location = new Point(445, 360);
            txtFechaa.Name = "txtFechaa";
            txtFechaa.Size = new Size(149, 22);
            txtFechaa.TabIndex = 79;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(314, 439);
            Label9.Name = "Label9";
            Label9.Size = new Size(125, 17);
            Label9.TabIndex = 78;
            Label9.Text = "Id tipo movimiento:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(314, 401);
            Label10.Name = "Label10";
            Label10.Size = new Size(134, 17);
            Label10.TabIndex = 77;
            Label10.Text = "Importe movimiento:";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(314, 363);
            Label12.Name = "Label12";
            Label12.Size = new Size(126, 17);
            Label12.TabIndex = 76;
            Label12.Text = "Fecha movimiento:";
            // 
            // txtIdMov
            // 
            txtIdMov.Location = new Point(148, 361);
            txtIdMov.Name = "txtIdMov";
            txtIdMov.Size = new Size(149, 22);
            txtIdMov.TabIndex = 75;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(17, 364);
            Label11.Name = "Label11";
            Label11.Size = new Size(100, 17);
            Label11.TabIndex = 74;
            Label11.Text = "ID Movimiento:";
            // 
            // txtIdTipoMov
            // 
            txtIdTipoMov.Location = new Point(148, 474);
            txtIdTipoMov.Name = "txtIdTipoMov";
            txtIdTipoMov.Size = new Size(149, 22);
            txtIdTipoMov.TabIndex = 73;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(148, 436);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(149, 22);
            txtImporte.TabIndex = 72;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(148, 398);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(149, 22);
            txtFecha.TabIndex = 71;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(17, 477);
            Label3.Name = "Label3";
            Label3.Size = new Size(125, 17);
            Label3.TabIndex = 70;
            Label3.Text = "Id tipo movimiento:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(17, 439);
            Label2.Name = "Label2";
            Label2.Size = new Size(134, 17);
            Label2.TabIndex = 69;
            Label2.Text = "Importe movimiento:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(17, 401);
            Label1.Name = "Label1";
            Label1.Size = new Size(126, 17);
            Label1.TabIndex = 68;
            Label1.Text = "Fecha movimiento:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(599, 315);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 38);
            BtnEliminar.TabIndex = 67;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(311, 315);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(113, 38);
            BtnActualizar.TabIndex = 66;
            BtnActualizar.Text = "ACTUALIZAR ";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(20, 315);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(107, 38);
            BtnAgregar.TabIndex = 65;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtIdCuenta
            // 
            txtIdCuenta.Location = new Point(148, 511);
            txtIdCuenta.Name = "txtIdCuenta";
            txtIdCuenta.Size = new Size(149, 22);
            txtIdCuenta.TabIndex = 83;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(18, 514);
            Label4.Name = "Label4";
            Label4.Size = new Size(72, 17);
            Label4.TabIndex = 82;
            Label4.Text = "Id Cuenta:";
            // 
            // TxtIdCuentaa
            // 
            TxtIdCuentaa.Location = new Point(445, 472);
            TxtIdCuentaa.Name = "TxtIdCuentaa";
            TxtIdCuentaa.Size = new Size(149, 22);
            TxtIdCuentaa.TabIndex = 85;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(315, 475);
            Label5.Name = "Label5";
            Label5.Size = new Size(72, 17);
            Label5.TabIndex = 84;
            Label5.Text = "Id Cuenta:";
            // 
            // Movimiento
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 562);
            Controls.Add(TxtIdCuentaa);
            Controls.Add(Label5);
            Controls.Add(txtIdCuenta);
            Controls.Add(Label4);
            Controls.Add(txtIdTipoMovv);
            Controls.Add(txtImportee);
            Controls.Add(txtFechaa);
            Controls.Add(Label9);
            Controls.Add(Label10);
            Controls.Add(Label12);
            Controls.Add(txtIdMov);
            Controls.Add(Label11);
            Controls.Add(txtIdTipoMov);
            Controls.Add(txtImporte);
            Controls.Add(txtFecha);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnAgregar);
            Controls.Add(DataGridView1);
            Name = "Movimiento";
            Text = "Movimiento";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(Movimiento_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal TextBox txtIdTipoMovv;
        internal TextBox txtImportee;
        internal TextBox txtFechaa;
        internal Label Label9;
        internal Label Label10;
        internal Label Label12;
        internal TextBox txtIdMov;
        internal Label Label11;
        internal TextBox txtIdTipoMov;
        internal TextBox txtImporte;
        internal TextBox txtFecha;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal Button BtnEliminar;
        internal Button BtnActualizar;
        internal Button BtnAgregar;
        internal TextBox txtIdCuenta;
        internal Label Label4;
        internal TextBox TxtIdCuentaa;
        internal Label Label5;
    }
}