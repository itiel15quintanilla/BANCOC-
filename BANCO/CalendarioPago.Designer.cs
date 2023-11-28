using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CalendarioPago : Form
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
            txtIdCreditoo = new TextBox();
            Label10 = new Label();
            txtIdCalendario = new TextBox();
            Label11 = new Label();
            txtIdCredito = new TextBox();
            Label2 = new Label();
            BtnEliminar = new Button();
            BtnEliminar.Click += new EventHandler(BtnEliminar_Click);
            BtnActualizar = new Button();
            BtnActualizar.Click += new EventHandler(BtnActualizar_Click);
            BtnAgregar = new Button();
            BtnAgregar.Click += new EventHandler(BtnAgregar_Click);
            Label12 = new Label();
            txtFechaa = new TextBox();
            Label1 = new Label();
            txtFecha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(14, 12);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(686, 238);
            DataGridView1.TabIndex = 0;
            // 
            // txtIdCreditoo
            // 
            txtIdCreditoo.Location = new Point(423, 339);
            txtIdCreditoo.Name = "txtIdCreditoo";
            txtIdCreditoo.Size = new Size(149, 22);
            txtIdCreditoo.TabIndex = 80;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(308, 344);
            Label10.Name = "Label10";
            Label10.Size = new Size(72, 17);
            Label10.TabIndex = 77;
            Label10.Text = "Id Credito:";
            // 
            // txtIdCalendario
            // 
            txtIdCalendario.Location = new Point(123, 304);
            txtIdCalendario.Name = "txtIdCalendario";
            txtIdCalendario.Size = new Size(149, 22);
            txtIdCalendario.TabIndex = 75;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(11, 307);
            Label11.Name = "Label11";
            Label11.Size = new Size(97, 17);
            Label11.TabIndex = 74;
            Label11.Text = "ID Calendario:";
            // 
            // txtIdCredito
            // 
            txtIdCredito.Location = new Point(123, 379);
            txtIdCredito.Name = "txtIdCredito";
            txtIdCredito.Size = new Size(149, 22);
            txtIdCredito.TabIndex = 72;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(11, 382);
            Label2.Name = "Label2";
            Label2.Size = new Size(72, 17);
            Label2.TabIndex = 69;
            Label2.Text = "Id Credito:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(593, 258);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 38);
            BtnEliminar.TabIndex = 67;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(305, 258);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(113, 38);
            BtnActualizar.TabIndex = 66;
            BtnActualizar.Text = "ACTUALIZAR ";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(14, 258);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(107, 38);
            BtnAgregar.TabIndex = 65;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(308, 306);
            Label12.Name = "Label12";
            Label12.Size = new Size(87, 17);
            Label12.TabIndex = 76;
            Label12.Text = "Fecha pago:";
            // 
            // txtFechaa
            // 
            txtFechaa.Location = new Point(423, 301);
            txtFechaa.Name = "txtFechaa";
            txtFechaa.Size = new Size(149, 22);
            txtFechaa.TabIndex = 79;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(11, 344);
            Label1.Name = "Label1";
            Label1.Size = new Size(87, 17);
            Label1.TabIndex = 68;
            Label1.Text = "Fecha pago:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(123, 341);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(149, 22);
            txtFecha.TabIndex = 71;
            // 
            // CalendarioPago
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 414);
            Controls.Add(txtIdCreditoo);
            Controls.Add(txtFechaa);
            Controls.Add(Label10);
            Controls.Add(Label12);
            Controls.Add(txtIdCalendario);
            Controls.Add(Label11);
            Controls.Add(txtIdCredito);
            Controls.Add(txtFecha);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnAgregar);
            Controls.Add(DataGridView1);
            Name = "CalendarioPago";
            Text = "CalendarioPago";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(CalendarioPago_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal TextBox txtIdCreditoo;
        internal Label Label10;
        internal TextBox txtIdCalendario;
        internal Label Label11;
        internal TextBox txtIdCredito;
        internal Label Label2;
        internal Button BtnEliminar;
        internal Button BtnActualizar;
        internal Button BtnAgregar;
        internal Label Label12;
        internal TextBox txtFechaa;
        internal Label Label1;
        internal TextBox txtFecha;
    }
}