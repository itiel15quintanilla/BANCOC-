using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TipoCuenta : Form
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
            txtTipoCuentaa = new TextBox();
            Label12 = new Label();
            txtIdTipoCuenta = new TextBox();
            Label11 = new Label();
            txtTipoCuenta = new TextBox();
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
            DataGridView1.Size = new Size(712, 213);
            DataGridView1.TabIndex = 0;
            // 
            // txtTipoCuentaa
            // 
            txtTipoCuentaa.Location = new Point(431, 290);
            txtTipoCuentaa.Name = "txtTipoCuentaa";
            txtTipoCuentaa.Size = new Size(149, 22);
            txtTipoCuentaa.TabIndex = 79;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(316, 295);
            Label12.Name = "Label12";
            Label12.Size = new Size(89, 17);
            Label12.TabIndex = 76;
            Label12.Text = "Tipo Cuenta:";
            // 
            // txtIdTipoCuenta
            // 
            txtIdTipoCuenta.Location = new Point(131, 293);
            txtIdTipoCuenta.Name = "txtIdTipoCuenta";
            txtIdTipoCuenta.Size = new Size(149, 22);
            txtIdTipoCuenta.TabIndex = 75;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(19, 296);
            Label11.Name = "Label11";
            Label11.Size = new Size(106, 17);
            Label11.TabIndex = 74;
            Label11.Text = "ID Tipo Cuenta:";
            // 
            // txtTipoCuenta
            // 
            txtTipoCuenta.Location = new Point(131, 330);
            txtTipoCuenta.Name = "txtTipoCuenta";
            txtTipoCuenta.Size = new Size(149, 22);
            txtTipoCuenta.TabIndex = 71;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(19, 333);
            Label1.Name = "Label1";
            Label1.Size = new Size(89, 17);
            Label1.TabIndex = 68;
            Label1.Text = "Tipo Cuenta:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(612, 247);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 38);
            BtnEliminar.TabIndex = 67;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(313, 247);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(113, 38);
            BtnActualizar.TabIndex = 66;
            BtnActualizar.Text = "ACTUALIZAR ";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(22, 247);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(107, 38);
            BtnAgregar.TabIndex = 65;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // TipoCuenta
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 365);
            Controls.Add(txtTipoCuentaa);
            Controls.Add(Label12);
            Controls.Add(txtIdTipoCuenta);
            Controls.Add(Label11);
            Controls.Add(txtTipoCuenta);
            Controls.Add(Label1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnAgregar);
            Controls.Add(DataGridView1);
            Name = "TipoCuenta";
            Text = "TipoCuenta";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(TipoCuenta_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal TextBox txtTipoCuentaa;
        internal Label Label12;
        internal TextBox txtIdTipoCuenta;
        internal Label Label11;
        internal TextBox txtTipoCuenta;
        internal Label Label1;
        internal Button BtnEliminar;
        internal Button BtnActualizar;
        internal Button BtnAgregar;
    }
}