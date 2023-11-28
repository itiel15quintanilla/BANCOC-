using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Credito : Form
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
            txtIdTipoCreditoo = new TextBox();
            txtIdClientee = new TextBox();
            Label9 = new Label();
            Label10 = new Label();
            txtIdCredito = new TextBox();
            Label11 = new Label();
            txtIdTipoCredito = new TextBox();
            txtIdCliente = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
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
            DataGridView1.Size = new Size(697, 209);
            DataGridView1.TabIndex = 0;
            // 
            // txtIdTipoCreditoo
            // 
            txtIdTipoCreditoo.Location = new Point(418, 318);
            txtIdTipoCreditoo.Name = "txtIdTipoCreditoo";
            txtIdTipoCreditoo.Size = new Size(149, 22);
            txtIdTipoCreditoo.TabIndex = 81;
            // 
            // txtIdClientee
            // 
            txtIdClientee.Location = new Point(418, 280);
            txtIdClientee.Name = "txtIdClientee";
            txtIdClientee.Size = new Size(149, 22);
            txtIdClientee.TabIndex = 80;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(303, 323);
            Label9.Name = "Label9";
            Label9.Size = new Size(97, 17);
            Label9.TabIndex = 78;
            Label9.Text = "Id tipo credito:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(303, 285);
            Label10.Name = "Label10";
            Label10.Size = new Size(66, 17);
            Label10.TabIndex = 77;
            Label10.Text = "Id Cliente";
            // 
            // txtIdCredito
            // 
            txtIdCredito.Location = new Point(124, 282);
            txtIdCredito.Name = "txtIdCredito";
            txtIdCredito.Size = new Size(149, 22);
            txtIdCredito.TabIndex = 75;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(12, 285);
            Label11.Name = "Label11";
            Label11.Size = new Size(74, 17);
            Label11.TabIndex = 74;
            Label11.Text = "ID Credito:";
            // 
            // txtIdTipoCredito
            // 
            txtIdTipoCredito.Location = new Point(124, 357);
            txtIdTipoCredito.Name = "txtIdTipoCredito";
            txtIdTipoCredito.Size = new Size(149, 22);
            txtIdTipoCredito.TabIndex = 73;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(124, 319);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(149, 22);
            txtIdCliente.TabIndex = 72;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(12, 360);
            Label3.Name = "Label3";
            Label3.Size = new Size(97, 17);
            Label3.TabIndex = 70;
            Label3.Text = "Id tipo credito:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(12, 322);
            Label2.Name = "Label2";
            Label2.Size = new Size(66, 17);
            Label2.TabIndex = 69;
            Label2.Text = "Id Cliente";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(602, 236);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 38);
            BtnEliminar.TabIndex = 67;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(306, 236);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(113, 38);
            BtnActualizar.TabIndex = 66;
            BtnActualizar.Text = "ACTUALIZAR ";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(15, 236);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(107, 38);
            BtnAgregar.TabIndex = 65;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // Credito
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 397);
            Controls.Add(txtIdTipoCreditoo);
            Controls.Add(txtIdClientee);
            Controls.Add(Label9);
            Controls.Add(Label10);
            Controls.Add(txtIdCredito);
            Controls.Add(Label11);
            Controls.Add(txtIdTipoCredito);
            Controls.Add(txtIdCliente);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnAgregar);
            Controls.Add(DataGridView1);
            Name = "Credito";
            Text = "Credito";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(Credito_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal TextBox txtIdTipoCreditoo;
        internal TextBox txtIdClientee;
        internal Label Label9;
        internal Label Label10;
        internal TextBox txtIdCredito;
        internal Label Label11;
        internal TextBox txtIdTipoCredito;
        internal TextBox txtIdCliente;
        internal Label Label3;
        internal Label Label2;
        internal Button BtnEliminar;
        internal Button BtnActualizar;
        internal Button BtnAgregar;
    }
}