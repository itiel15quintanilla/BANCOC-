using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Pago : Form
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
            txtIdPago = new TextBox();
            Label11 = new Label();
            txtTipoMov = new TextBox();
            Label1 = new Label();
            BtnEliminar = new Button();
            BtnEliminar.Click += new EventHandler(BtnEliminar_Click);
            BtnActualizar = new Button();
            BtnActualizar.Click += new EventHandler(BtnActualizar_Click);
            BtnAgregar = new Button();
            BtnAgregar.Click += new EventHandler(BtnAgregar_Click);
            txtMonto = new TextBox();
            Label2 = new Label();
            txtMontoo = new TextBox();
            Label3 = new Label();
            txtTipoMovv = new TextBox();
            Label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(9, 12);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(722, 267);
            DataGridView1.TabIndex = 0;
            // 
            // txtIdPago
            // 
            txtIdPago.Location = new Point(142, 345);
            txtIdPago.Name = "txtIdPago";
            txtIdPago.Size = new Size(149, 22);
            txtIdPago.TabIndex = 86;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(19, 348);
            Label11.Name = "Label11";
            Label11.Size = new Size(62, 17);
            Label11.TabIndex = 85;
            Label11.Text = "ID Pago:";
            // 
            // txtTipoMov
            // 
            txtTipoMov.Location = new Point(142, 405);
            txtTipoMov.Name = "txtTipoMov";
            txtTipoMov.Size = new Size(149, 22);
            txtTipoMov.TabIndex = 84;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(19, 408);
            Label1.Name = "Label1";
            Label1.Size = new Size(125, 17);
            Label1.TabIndex = 83;
            Label1.Text = "Id tipo movimiento:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(612, 299);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 38);
            BtnEliminar.TabIndex = 82;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(313, 299);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(113, 38);
            BtnActualizar.TabIndex = 81;
            BtnActualizar.Text = "ACTUALIZAR ";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(22, 299);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(107, 38);
            BtnAgregar.TabIndex = 80;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(142, 377);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(149, 22);
            txtMonto.TabIndex = 90;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(19, 380);
            Label2.Name = "Label2";
            Label2.Size = new Size(51, 17);
            Label2.TabIndex = 89;
            Label2.Text = "Monto:";
            // 
            // txtMontoo
            // 
            txtMontoo.Location = new Point(438, 343);
            txtMontoo.Name = "txtMontoo";
            txtMontoo.Size = new Size(149, 22);
            txtMontoo.TabIndex = 94;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(315, 346);
            Label3.Name = "Label3";
            Label3.Size = new Size(51, 17);
            Label3.TabIndex = 93;
            Label3.Text = "Monto:";
            // 
            // txtTipoMovv
            // 
            txtTipoMovv.Location = new Point(438, 371);
            txtTipoMovv.Name = "txtTipoMovv";
            txtTipoMovv.Size = new Size(149, 22);
            txtTipoMovv.TabIndex = 92;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(315, 374);
            Label4.Name = "Label4";
            Label4.Size = new Size(125, 17);
            Label4.TabIndex = 91;
            Label4.Text = "Id tipo movimiento:";
            // 
            // Pago
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 449);
            Controls.Add(txtMontoo);
            Controls.Add(Label3);
            Controls.Add(txtTipoMovv);
            Controls.Add(Label4);
            Controls.Add(txtMonto);
            Controls.Add(Label2);
            Controls.Add(txtIdPago);
            Controls.Add(Label11);
            Controls.Add(txtTipoMov);
            Controls.Add(Label1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnAgregar);
            Controls.Add(DataGridView1);
            Name = "Pago";
            Text = "Pago";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(Pago_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal TextBox txtIdPago;
        internal Label Label11;
        internal TextBox txtTipoMov;
        internal Label Label1;
        internal Button BtnEliminar;
        internal Button BtnActualizar;
        internal Button BtnAgregar;
        internal TextBox txtMonto;
        internal Label Label2;
        internal TextBox txtMontoo;
        internal Label Label3;
        internal TextBox txtTipoMovv;
        internal Label Label4;
    }
}