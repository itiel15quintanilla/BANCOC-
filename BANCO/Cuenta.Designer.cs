using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Cuenta : Form
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
            txtIdTipoCuentaa = new TextBox();
            txtIdClientee = new TextBox();
            txtFechaa = new TextBox();
            Label9 = new Label();
            Label10 = new Label();
            Label12 = new Label();
            txtIdCuenta = new TextBox();
            Label11 = new Label();
            txtIdTipoCuenta = new TextBox();
            txtIdCliente = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(12, 12);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(702, 351);
            DataGridView1.TabIndex = 0;
            // 
            // txtIdTipoCuentaa
            // 
            txtIdTipoCuentaa.Location = new Point(437, 507);
            txtIdTipoCuentaa.Name = "txtIdTipoCuentaa";
            txtIdTipoCuentaa.Size = new Size(149, 22);
            txtIdTipoCuentaa.TabIndex = 64;
            // 
            // txtIdClientee
            // 
            txtIdClientee.Location = new Point(437, 469);
            txtIdClientee.Name = "txtIdClientee";
            txtIdClientee.Size = new Size(149, 22);
            txtIdClientee.TabIndex = 63;
            // 
            // txtFechaa
            // 
            txtFechaa.Location = new Point(437, 431);
            txtFechaa.Name = "txtFechaa";
            txtFechaa.Size = new Size(149, 22);
            txtFechaa.TabIndex = 62;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(322, 512);
            Label9.Name = "Label9";
            Label9.Size = new Size(97, 17);
            Label9.TabIndex = 59;
            Label9.Text = "Id tipo cuenta:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(322, 474);
            Label10.Name = "Label10";
            Label10.Size = new Size(66, 17);
            Label10.TabIndex = 58;
            Label10.Text = "Id Cliente";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(322, 436);
            Label12.Name = "Label12";
            Label12.Size = new Size(109, 17);
            Label12.TabIndex = 57;
            Label12.Text = "Fecha apertura:";
            // 
            // txtIdCuenta
            // 
            txtIdCuenta.Location = new Point(137, 434);
            txtIdCuenta.Name = "txtIdCuenta";
            txtIdCuenta.Size = new Size(149, 22);
            txtIdCuenta.TabIndex = 56;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(25, 437);
            Label11.Name = "Label11";
            Label11.Size = new Size(74, 17);
            Label11.TabIndex = 55;
            Label11.Text = "ID Cuenta:";
            // 
            // txtIdTipoCuenta
            // 
            txtIdTipoCuenta.Location = new Point(137, 547);
            txtIdTipoCuenta.Name = "txtIdTipoCuenta";
            txtIdTipoCuenta.Size = new Size(149, 22);
            txtIdTipoCuenta.TabIndex = 52;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(137, 509);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(149, 22);
            txtIdCliente.TabIndex = 51;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(137, 471);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(149, 22);
            txtFecha.TabIndex = 50;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(25, 550);
            Label3.Name = "Label3";
            Label3.Size = new Size(97, 17);
            Label3.TabIndex = 47;
            Label3.Text = "Id tipo cuenta:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(25, 512);
            Label2.Name = "Label2";
            Label2.Size = new Size(66, 17);
            Label2.TabIndex = 46;
            Label2.Text = "Id Cliente";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(25, 474);
            Label1.Name = "Label1";
            Label1.Size = new Size(109, 17);
            Label1.TabIndex = 45;
            Label1.Text = "Fecha apertura:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(607, 388);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 38);
            BtnEliminar.TabIndex = 44;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(319, 388);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(113, 38);
            BtnActualizar.TabIndex = 43;
            BtnActualizar.Text = "ACTUALIZAR ";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(28, 388);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(107, 38);
            BtnAgregar.TabIndex = 42;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // Cuenta
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 605);
            Controls.Add(txtIdTipoCuentaa);
            Controls.Add(txtIdClientee);
            Controls.Add(txtFechaa);
            Controls.Add(Label9);
            Controls.Add(Label10);
            Controls.Add(Label12);
            Controls.Add(txtIdCuenta);
            Controls.Add(Label11);
            Controls.Add(txtIdTipoCuenta);
            Controls.Add(txtIdCliente);
            Controls.Add(txtFecha);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnAgregar);
            Controls.Add(DataGridView1);
            Name = "Cuenta";
            Text = "Cuenta";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(Cuenta_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal TextBox txtIdTipoCuentaa;
        internal TextBox txtIdClientee;
        internal TextBox txtFechaa;
        internal Label Label9;
        internal Label Label10;
        internal Label Label12;
        internal TextBox txtIdCuenta;
        internal Label Label11;
        internal TextBox txtIdTipoCuenta;
        internal TextBox txtIdCliente;
        internal TextBox txtFecha;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal Button BtnEliminar;
        internal Button BtnActualizar;
        internal Button BtnAgregar;
    }
}