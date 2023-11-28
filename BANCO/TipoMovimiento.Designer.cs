using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TipoMovimiento : Form
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
            txtTipoMovv = new TextBox();
            Label12 = new Label();
            txtIdTipoMov = new TextBox();
            Label11 = new Label();
            txtTipoMov = new TextBox();
            Label1 = new Label();
            BtnEliminar = new Button();
            BtnEliminar.Click += new EventHandler(BtnEliminar_Click);
            BtnActualizar = new Button();
            BtnActualizar.Click += new EventHandler(BtnActualizar_Click);
            BtnAgregar = new Button();
            BtnAgregar.Click += new EventHandler(BtnAgregar_Click);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(12, 12);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(699, 271);
            DataGridView1.TabIndex = 0;
            // 
            // txtTipoMovv
            // 
            txtTipoMovv.Location = new Point(423, 352);
            txtTipoMovv.Name = "txtTipoMovv";
            txtTipoMovv.Size = new Size(149, 22);
            txtTipoMovv.TabIndex = 88;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(308, 357);
            Label12.Name = "Label12";
            Label12.Size = new Size(115, 17);
            Label12.TabIndex = 87;
            Label12.Text = "Tipo Movimiento:";
            // 
            // txtIdTipoMov
            // 
            txtIdTipoMov.Location = new Point(143, 355);
            txtIdTipoMov.Name = "txtIdTipoMov";
            txtIdTipoMov.Size = new Size(149, 22);
            txtIdTipoMov.TabIndex = 86;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(11, 358);
            Label11.Name = "Label11";
            Label11.Size = new Size(132, 17);
            Label11.TabIndex = 85;
            Label11.Text = "ID Tipo Movimiento:";
            // 
            // txtTipoMov
            // 
            txtTipoMov.Location = new Point(143, 392);
            txtTipoMov.Name = "txtTipoMov";
            txtTipoMov.Size = new Size(149, 22);
            txtTipoMov.TabIndex = 84;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(11, 395);
            Label1.Name = "Label1";
            Label1.Size = new Size(115, 17);
            Label1.TabIndex = 83;
            Label1.Text = "Tipo Movimiento:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(604, 309);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 38);
            BtnEliminar.TabIndex = 82;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(305, 309);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(113, 38);
            BtnActualizar.TabIndex = 81;
            BtnActualizar.Text = "ACTUALIZAR ";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(14, 309);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(107, 38);
            BtnAgregar.TabIndex = 80;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // TipoMovimiento
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 431);
            Controls.Add(txtTipoMovv);
            Controls.Add(Label12);
            Controls.Add(txtIdTipoMov);
            Controls.Add(Label11);
            Controls.Add(txtTipoMov);
            Controls.Add(Label1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnAgregar);
            Controls.Add(DataGridView1);
            Name = "TipoMovimiento";
            Text = "TipoMovimiento";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(TipoMovimiento_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal TextBox txtTipoMovv;
        internal Label Label12;
        internal TextBox txtIdTipoMov;
        internal Label Label11;
        internal TextBox txtTipoMov;
        internal Label Label1;
        internal Button BtnEliminar;
        internal Button BtnActualizar;
        internal Button BtnAgregar;
    }
}