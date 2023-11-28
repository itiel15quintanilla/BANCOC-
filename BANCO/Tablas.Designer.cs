using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Tablas : Form
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
            this.BtnSucursal = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnCuenta = new System.Windows.Forms.Button();
            this.BtnTipoCuena = new System.Windows.Forms.Button();
            this.BtnMov = new System.Windows.Forms.Button();
            this.BtnTipoMov = new System.Windows.Forms.Button();
            this.BtnCalPago = new System.Windows.Forms.Button();
            this.BtnPago = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSucursal
            // 
            this.BtnSucursal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSucursal.Location = new System.Drawing.Point(63, 32);
            this.BtnSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSucursal.Name = "BtnSucursal";
            this.BtnSucursal.Size = new System.Drawing.Size(122, 100);
            this.BtnSucursal.TabIndex = 14;
            this.BtnSucursal.Text = "SUCURSAL";
            this.BtnSucursal.UseVisualStyleBackColor = false;
            this.BtnSucursal.Click += new System.EventHandler(this.BtnSucursal_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(238, 32);
            this.BtnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(122, 100);
            this.BtnCliente.TabIndex = 15;
            this.BtnCliente.Text = "CLIENTE";
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnCuenta
            // 
            this.BtnCuenta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuenta.Location = new System.Drawing.Point(415, 32);
            this.BtnCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCuenta.Name = "BtnCuenta";
            this.BtnCuenta.Size = new System.Drawing.Size(122, 100);
            this.BtnCuenta.TabIndex = 16;
            this.BtnCuenta.Text = "CUENTA";
            this.BtnCuenta.UseVisualStyleBackColor = false;
            this.BtnCuenta.Click += new System.EventHandler(this.BtnCuenta_Click);
            // 
            // BtnTipoCuena
            // 
            this.BtnTipoCuena.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTipoCuena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTipoCuena.Location = new System.Drawing.Point(607, 32);
            this.BtnTipoCuena.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTipoCuena.Name = "BtnTipoCuena";
            this.BtnTipoCuena.Size = new System.Drawing.Size(122, 100);
            this.BtnTipoCuena.TabIndex = 17;
            this.BtnTipoCuena.Text = "TIPO CUENTA";
            this.BtnTipoCuena.UseVisualStyleBackColor = false;
            this.BtnTipoCuena.Click += new System.EventHandler(this.BtnTipoCuena_Click);
            // 
            // BtnMov
            // 
            this.BtnMov.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMov.Location = new System.Drawing.Point(785, 32);
            this.BtnMov.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMov.Name = "BtnMov";
            this.BtnMov.Size = new System.Drawing.Size(132, 100);
            this.BtnMov.TabIndex = 18;
            this.BtnMov.Text = "MOVIMIENTO";
            this.BtnMov.UseVisualStyleBackColor = false;
            this.BtnMov.Click += new System.EventHandler(this.BtnMov_Click);
            // 
            // BtnTipoMov
            // 
            this.BtnTipoMov.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTipoMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTipoMov.Location = new System.Drawing.Point(55, 239);
            this.BtnTipoMov.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTipoMov.Name = "BtnTipoMov";
            this.BtnTipoMov.Size = new System.Drawing.Size(130, 100);
            this.BtnTipoMov.TabIndex = 19;
            this.BtnTipoMov.Text = "TIPO MOVIMIENTO";
            this.BtnTipoMov.UseVisualStyleBackColor = false;
            this.BtnTipoMov.Click += new System.EventHandler(this.BtnTipoMov_Click);
            // 
            // BtnCalPago
            // 
            this.BtnCalPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalPago.Location = new System.Drawing.Point(603, 239);
            this.BtnCalPago.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCalPago.Name = "BtnCalPago";
            this.BtnCalPago.Size = new System.Drawing.Size(122, 100);
            this.BtnCalPago.TabIndex = 20;
            this.BtnCalPago.Text = "CALENDRIO PAGO";
            this.BtnCalPago.UseVisualStyleBackColor = false;
            this.BtnCalPago.Click += new System.EventHandler(this.BtnCalPago_Click);
            // 
            // BtnPago
            // 
            this.BtnPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPago.Location = new System.Drawing.Point(795, 239);
            this.BtnPago.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPago.Name = "BtnPago";
            this.BtnPago.Size = new System.Drawing.Size(122, 100);
            this.BtnPago.TabIndex = 21;
            this.BtnPago.Text = "PAGO";
            this.BtnPago.UseVisualStyleBackColor = false;
            this.BtnPago.Click += new System.EventHandler(this.BtnPago_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(238, 239);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(122, 100);
            this.Button1.TabIndex = 22;
            this.Button1.Text = "CREDITO";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(415, 239);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(122, 100);
            this.Button2.TabIndex = 23;
            this.Button2.Text = "TIPO CREDITO";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Tablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 436);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.BtnPago);
            this.Controls.Add(this.BtnCalPago);
            this.Controls.Add(this.BtnTipoMov);
            this.Controls.Add(this.BtnMov);
            this.Controls.Add(this.BtnTipoCuena);
            this.Controls.Add(this.BtnCuenta);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.BtnSucursal);
            this.Name = "Tablas";
            this.Text = "Tablas";
            this.Load += new System.EventHandler(this.Tablas_Load);
            this.ResumeLayout(false);

        }

        private Button BtnSucursal;
        private Button BtnCliente;
        private Button BtnCuenta;
        private Button BtnTipoCuena;
        private Button BtnMov;
        private Button BtnTipoMov;
        private Button BtnCalPago;
        private Button BtnPago;
        private Button Button1;
        private Button Button2;
    }
}