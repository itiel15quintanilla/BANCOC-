using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Sucursal : Form
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
            BtnAgregar = new Button();
            BtnAgregar.Click += new EventHandler(BtnAgregar_Click);
            BtnActualizar = new Button();
            BtnActualizar.Click += new EventHandler(BtnActualizar_Click);
            BtnEliminar = new Button();
            BtnEliminar.Click += new EventHandler(BtnEliminar_Click);
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtCiudad = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            Label5 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            txtIdSucursal = new TextBox();
            Label11 = new Label();
            txtCorreoo = new TextBox();
            txtTelefonoo = new TextBox();
            txtCiudadd = new TextBox();
            txtDireccionn = new TextBox();
            txtNombree = new TextBox();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            Label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(12, 26);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(700, 368);
            DataGridView1.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(19, 413);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(107, 38);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(303, 413);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(113, 38);
            BtnActualizar.TabIndex = 2;
            BtnActualizar.Text = "ACTUALIZAR ";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(605, 413);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 38);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(97, 643);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(149, 22);
            txtCorreo.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(97, 606);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(149, 22);
            txtTelefono.TabIndex = 18;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(97, 570);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(149, 22);
            txtCiudad.TabIndex = 17;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(97, 532);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(149, 22);
            txtDireccion.TabIndex = 16;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 494);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 22);
            txtNombre.TabIndex = 15;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(16, 648);
            Label5.Name = "Label5";
            Label5.Size = new Size(55, 17);
            Label5.TabIndex = 14;
            Label5.Text = "Correo:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(16, 611);
            Label4.Name = "Label4";
            Label4.Size = new Size(68, 17);
            Label4.TabIndex = 13;
            Label4.Text = "Telefono:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(16, 575);
            Label3.Name = "Label3";
            Label3.Size = new Size(56, 17);
            Label3.TabIndex = 12;
            Label3.Text = "Ciudad:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(16, 537);
            Label2.Name = "Label2";
            Label2.Size = new Size(71, 17);
            Label2.TabIndex = 11;
            Label2.Text = "Direccion:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(16, 499);
            Label1.Name = "Label1";
            Label1.Size = new Size(62, 17);
            Label1.TabIndex = 10;
            Label1.Text = "Nombre:";
            // 
            // txtIdSucursal
            // 
            txtIdSucursal.Location = new Point(97, 457);
            txtIdSucursal.Name = "txtIdSucursal";
            txtIdSucursal.Size = new Size(149, 22);
            txtIdSucursal.TabIndex = 31;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(16, 462);
            Label11.Name = "Label11";
            Label11.Size = new Size(84, 17);
            Label11.TabIndex = 30;
            Label11.Text = "ID Sucursal:";
            // 
            // txtCorreoo
            // 
            txtCorreoo.Location = new Point(387, 605);
            txtCorreoo.Name = "txtCorreoo";
            txtCorreoo.Size = new Size(149, 22);
            txtCorreoo.TabIndex = 41;
            // 
            // txtTelefonoo
            // 
            txtTelefonoo.Location = new Point(387, 568);
            txtTelefonoo.Name = "txtTelefonoo";
            txtTelefonoo.Size = new Size(149, 22);
            txtTelefonoo.TabIndex = 40;
            // 
            // txtCiudadd
            // 
            txtCiudadd.Location = new Point(387, 532);
            txtCiudadd.Name = "txtCiudadd";
            txtCiudadd.Size = new Size(149, 22);
            txtCiudadd.TabIndex = 39;
            // 
            // txtDireccionn
            // 
            txtDireccionn.Location = new Point(387, 494);
            txtDireccionn.Name = "txtDireccionn";
            txtDireccionn.Size = new Size(149, 22);
            txtDireccionn.TabIndex = 38;
            // 
            // txtNombree
            // 
            txtNombree.Location = new Point(387, 456);
            txtNombree.Name = "txtNombree";
            txtNombree.Size = new Size(149, 22);
            txtNombree.TabIndex = 37;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(306, 610);
            Label7.Name = "Label7";
            Label7.Size = new Size(55, 17);
            Label7.TabIndex = 36;
            Label7.Text = "Correo:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(306, 573);
            Label8.Name = "Label8";
            Label8.Size = new Size(68, 17);
            Label8.TabIndex = 35;
            Label8.Text = "Telefono:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(306, 537);
            Label9.Name = "Label9";
            Label9.Size = new Size(56, 17);
            Label9.TabIndex = 34;
            Label9.Text = "Ciudad:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(306, 499);
            Label10.Name = "Label10";
            Label10.Size = new Size(71, 17);
            Label10.TabIndex = 33;
            Label10.Text = "Direccion:";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(306, 461);
            Label12.Name = "Label12";
            Label12.Size = new Size(62, 17);
            Label12.TabIndex = 32;
            Label12.Text = "Nombre:";
            // 
            // Sucursal
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 677);
            Controls.Add(txtCorreoo);
            Controls.Add(txtTelefonoo);
            Controls.Add(txtCiudadd);
            Controls.Add(txtDireccionn);
            Controls.Add(txtNombree);
            Controls.Add(Label7);
            Controls.Add(Label8);
            Controls.Add(Label9);
            Controls.Add(Label10);
            Controls.Add(Label12);
            Controls.Add(txtIdSucursal);
            Controls.Add(Label11);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtCiudad);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnAgregar);
            Controls.Add(DataGridView1);
            Name = "Sucursal";
            Text = "Sucursal";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(Sucursal_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal Button BtnAgregar;
        internal Button BtnActualizar;
        internal Button BtnEliminar;
        internal TextBox txtCorreo;
        internal TextBox txtTelefono;
        internal TextBox txtCiudad;
        internal TextBox txtDireccion;
        internal TextBox txtNombre;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal TextBox txtIdSucursal;
        internal Label Label11;
        internal TextBox txtCorreoo;
        internal TextBox txtTelefonoo;
        internal TextBox txtCiudadd;
        internal TextBox txtDireccionn;
        internal TextBox txtNombree;
        internal Label Label7;
        internal Label Label8;
        internal Label Label9;
        internal Label Label10;
        internal Label Label12;
    }
}