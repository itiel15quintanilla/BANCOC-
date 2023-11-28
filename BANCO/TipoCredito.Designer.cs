using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TipoCredito : Form
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
            txtTipoCreditoo = new TextBox();
            Label12 = new Label();
            txtIdTipoCredito = new TextBox();
            Label11 = new Label();
            txtTipoCredito = new TextBox();
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
            DataGridView1.Location = new Point(14, 12);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(694, 285);
            DataGridView1.TabIndex = 0;
            // 
            // txtTipoCreditoo
            // 
            txtTipoCreditoo.Location = new Point(423, 363);
            txtTipoCreditoo.Name = "txtTipoCreditoo";
            txtTipoCreditoo.Size = new Size(149, 22);
            txtTipoCreditoo.TabIndex = 97;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(308, 368);
            Label12.Name = "Label12";
            Label12.Size = new Size(89, 17);
            Label12.TabIndex = 96;
            Label12.Text = "Tipo Credito:";
            // 
            // txtIdTipoCredito
            // 
            txtIdTipoCredito.Location = new Point(143, 366);
            txtIdTipoCredito.Name = "txtIdTipoCredito";
            txtIdTipoCredito.Size = new Size(149, 22);
            txtIdTipoCredito.TabIndex = 95;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(11, 369);
            Label11.Name = "Label11";
            Label11.Size = new Size(106, 17);
            Label11.TabIndex = 94;
            Label11.Text = "ID Tipo Credito:";
            // 
            // txtTipoCredito
            // 
            txtTipoCredito.Location = new Point(143, 403);
            txtTipoCredito.Name = "txtTipoCredito";
            txtTipoCredito.Size = new Size(149, 22);
            txtTipoCredito.TabIndex = 93;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(11, 406);
            Label1.Name = "Label1";
            Label1.Size = new Size(89, 17);
            Label1.TabIndex = 92;
            Label1.Text = "Tipo Credito:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(604, 320);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 38);
            BtnEliminar.TabIndex = 91;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(305, 320);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(113, 38);
            BtnActualizar.TabIndex = 90;
            BtnActualizar.Text = "ACTUALIZAR ";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(14, 320);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(107, 38);
            BtnAgregar.TabIndex = 89;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // TipoCredito
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 439);
            Controls.Add(txtTipoCreditoo);
            Controls.Add(Label12);
            Controls.Add(txtIdTipoCredito);
            Controls.Add(Label11);
            Controls.Add(txtTipoCredito);
            Controls.Add(Label1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnAgregar);
            Controls.Add(DataGridView1);
            Name = "TipoCredito";
            Text = "TipoCredito";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(TipoCredito_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal TextBox txtTipoCreditoo;
        internal Label Label12;
        internal TextBox txtIdTipoCredito;
        internal Label Label11;
        internal TextBox txtTipoCredito;
        internal Label Label1;
        internal Button BtnEliminar;
        internal Button BtnActualizar;
        internal Button BtnAgregar;
    }
}