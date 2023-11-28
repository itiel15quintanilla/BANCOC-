using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Cliente : Form
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
            txtIdCliente = new TextBox();
            Label11 = new Label();
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
            BtnEliminar = new Button();
            BtnEliminar.Click += new EventHandler(BtnEliminar_Click);
            BtnActualizar = new Button();
            BtnActualizar.Click += new EventHandler(BtnActualizar_Click);
            BtnAgregar = new Button();
            BtnAgregar.Click += new EventHandler(BtnAgregar_Click);
            TxtApPat = new TextBox();
            Label15 = new Label();
            TxtApMat = new TextBox();
            Label16 = new Label();
            txtApPatt = new TextBox();
            Label13 = new Label();
            txtApMatt = new TextBox();
            Label14 = new Label();
            txtIdSucursal = new TextBox();
            Label6 = new Label();
            TextBox1 = new TextBox();
            Label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(12, 12);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowTemplate.Height = 24;
            DataGridView1.Size = new Size(699, 350);
            DataGridView1.TabIndex = 0;
            // 
            // txtCorreoo
            // 
            txtCorreoo.Location = new Point(428, 594);
            txtCorreoo.Name = "txtCorreoo";
            txtCorreoo.Size = new Size(149, 22);
            txtCorreoo.TabIndex = 68;
            // 
            // txtTelefonoo
            // 
            txtTelefonoo.Location = new Point(428, 567);
            txtTelefonoo.Name = "txtTelefonoo";
            txtTelefonoo.Size = new Size(149, 22);
            txtTelefonoo.TabIndex = 67;
            // 
            // txtCiudadd
            // 
            txtCiudadd.Location = new Point(428, 541);
            txtCiudadd.Name = "txtCiudadd";
            txtCiudadd.Size = new Size(149, 22);
            txtCiudadd.TabIndex = 66;
            // 
            // txtDireccionn
            // 
            txtDireccionn.Location = new Point(428, 515);
            txtDireccionn.Name = "txtDireccionn";
            txtDireccionn.Size = new Size(149, 22);
            txtDireccionn.TabIndex = 65;
            // 
            // txtNombree
            // 
            txtNombree.Location = new Point(428, 436);
            txtNombree.Name = "txtNombree";
            txtNombree.Size = new Size(149, 22);
            txtNombree.TabIndex = 64;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(299, 599);
            Label7.Name = "Label7";
            Label7.Size = new Size(55, 17);
            Label7.TabIndex = 63;
            Label7.Text = "Correo:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(299, 572);
            Label8.Name = "Label8";
            Label8.Size = new Size(68, 17);
            Label8.TabIndex = 62;
            Label8.Text = "Telefono:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(299, 546);
            Label9.Name = "Label9";
            Label9.Size = new Size(56, 17);
            Label9.TabIndex = 61;
            Label9.Text = "Ciudad:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(299, 520);
            Label10.Name = "Label10";
            Label10.Size = new Size(71, 17);
            Label10.TabIndex = 60;
            Label10.Text = "Direccion:";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(299, 441);
            Label12.Name = "Label12";
            Label12.Size = new Size(62, 17);
            Label12.TabIndex = 59;
            Label12.Text = "Nombre:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(126, 434);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(149, 22);
            txtIdCliente.TabIndex = 58;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(11, 439);
            Label11.Name = "Label11";
            Label11.Size = new Size(72, 17);
            Label11.TabIndex = 57;
            Label11.Text = "ID Cliente:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(126, 621);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(149, 22);
            txtCorreo.TabIndex = 56;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(126, 594);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(149, 22);
            txtTelefono.TabIndex = 55;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(126, 568);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(149, 22);
            txtCiudad.TabIndex = 54;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(126, 542);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(149, 22);
            txtDireccion.TabIndex = 53;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 462);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 22);
            txtNombre.TabIndex = 52;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(11, 626);
            Label5.Name = "Label5";
            Label5.Size = new Size(55, 17);
            Label5.TabIndex = 51;
            Label5.Text = "Correo:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(11, 599);
            Label4.Name = "Label4";
            Label4.Size = new Size(68, 17);
            Label4.TabIndex = 50;
            Label4.Text = "Telefono:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(11, 573);
            Label3.Name = "Label3";
            Label3.Size = new Size(56, 17);
            Label3.TabIndex = 49;
            Label3.Text = "Ciudad:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(11, 547);
            Label2.Name = "Label2";
            Label2.Size = new Size(71, 17);
            Label2.TabIndex = 48;
            Label2.Text = "Direccion:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(11, 467);
            Label1.Name = "Label1";
            Label1.Size = new Size(62, 17);
            Label1.TabIndex = 47;
            Label1.Text = "Nombre:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(600, 390);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 38);
            BtnEliminar.TabIndex = 46;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(298, 390);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(117, 38);
            BtnActualizar.TabIndex = 45;
            BtnActualizar.Text = "ACTUALIZAR ";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(14, 390);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(107, 38);
            BtnAgregar.TabIndex = 44;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // TxtApPat
            // 
            TxtApPat.Location = new Point(126, 489);
            TxtApPat.Name = "TxtApPat";
            TxtApPat.Size = new Size(149, 22);
            TxtApPat.TabIndex = 74;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Location = new Point(11, 494);
            Label15.Name = "Label15";
            Label15.Size = new Size(112, 17);
            Label15.TabIndex = 73;
            Label15.Text = "Apellido Paterno";
            // 
            // TxtApMat
            // 
            TxtApMat.Location = new Point(126, 516);
            TxtApMat.Name = "TxtApMat";
            TxtApMat.Size = new Size(149, 22);
            TxtApMat.TabIndex = 72;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Location = new Point(11, 521);
            Label16.Name = "Label16";
            Label16.Size = new Size(118, 17);
            Label16.TabIndex = 71;
            Label16.Text = "Apellido Materno:";
            // 
            // txtApPatt
            // 
            txtApPatt.Location = new Point(428, 461);
            txtApPatt.Name = "txtApPatt";
            txtApPatt.Size = new Size(149, 22);
            txtApPatt.TabIndex = 78;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Location = new Point(299, 466);
            Label13.Name = "Label13";
            Label13.Size = new Size(116, 17);
            Label13.TabIndex = 77;
            Label13.Text = "Apellido Paterno:";
            // 
            // txtApMatt
            // 
            txtApMatt.Location = new Point(428, 488);
            txtApMatt.Name = "txtApMatt";
            txtApMatt.Size = new Size(149, 22);
            txtApMatt.TabIndex = 76;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Location = new Point(299, 493);
            Label14.Name = "Label14";
            Label14.Size = new Size(118, 17);
            Label14.TabIndex = 75;
            Label14.Text = "Apellido Materno:";
            // 
            // txtIdSucursal
            // 
            txtIdSucursal.Location = new Point(127, 649);
            txtIdSucursal.Name = "txtIdSucursal";
            txtIdSucursal.Size = new Size(149, 22);
            txtIdSucursal.TabIndex = 80;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(12, 654);
            Label6.Name = "Label6";
            Label6.Size = new Size(84, 17);
            Label6.TabIndex = 79;
            Label6.Text = "ID Sucursal:";
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(428, 621);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(149, 22);
            TextBox1.TabIndex = 82;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Location = new Point(299, 624);
            Label17.Name = "Label17";
            Label17.Size = new Size(84, 17);
            Label17.TabIndex = 81;
            Label17.Text = "ID Sucursal:";
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 704);
            Controls.Add(TextBox1);
            Controls.Add(Label17);
            Controls.Add(txtIdSucursal);
            Controls.Add(Label6);
            Controls.Add(txtApPatt);
            Controls.Add(Label13);
            Controls.Add(txtApMatt);
            Controls.Add(Label14);
            Controls.Add(TxtApPat);
            Controls.Add(Label15);
            Controls.Add(TxtApMat);
            Controls.Add(Label16);
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
            Controls.Add(txtIdCliente);
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
            Name = "Cliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(Cliente_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView DataGridView1;
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
        internal TextBox txtIdCliente;
        internal Label Label11;
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
        internal Button BtnEliminar;
        internal Button BtnActualizar;
        internal Button BtnAgregar;
        internal TextBox TxtApPat;
        internal Label Label15;
        internal TextBox TxtApMat;
        internal Label Label16;
        internal TextBox txtApPatt;
        internal Label Label13;
        internal TextBox txtApMatt;
        internal Label Label14;
        internal TextBox txtIdSucursal;
        internal Label Label6;
        internal TextBox TextBox1;
        internal Label Label17;
    }
}