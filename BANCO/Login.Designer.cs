using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
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
            label4 = new Label();
            button1 = new Button();
            button1.Click += new EventHandler(button1_Click);
            label1 = new Label();
            textBox2 = new TextBox();
            textBox2.TextChanged += new EventHandler(textBox2_TextChanged);
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(69, 27);
            label4.Name = "label4";
            label4.Size = new Size(305, 45);
            label4.TabIndex = 14;
            label4.Text = "¡BIENVENIDO!";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(150, 400);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(100, 28);
            button1.TabIndex = 13;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 29);
            label1.TabIndex = 8;
            label1.Text = "INICIAR SESIÓN";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 318);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 22);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 227);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 22);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.0f, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 227);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 9;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12.0f, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 317);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 10;
            label3.Text = "Contraseña:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Login";
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        private Label label4;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
    }
}