namespace Practico1
{
    partial class Formulario1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BGuardar = new Button();
            BEliminar = new Button();
            LApellido = new Label();
            LNombre = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            BSalir = new Button();
            SuspendLayout();
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(25, 150);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(94, 29);
            BGuardar.TabIndex = 0;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click_1;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(141, 150);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(94, 29);
            BEliminar.TabIndex = 1;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(12, 39);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(66, 20);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(14, 96);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(64, 20);
            LNombre.TabIndex = 3;
            LNombre.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 181);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(84, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // BSalir
            // 
            BSalir.Location = new Point(257, 220);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(94, 29);
            BSalir.TabIndex = 7;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            // 
            // Formulario1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(BSalir);
            Name = "Formulario1";
            Text = "Mi Primer Forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGuardar;
        private Button BEliminar;
        private Label LApellido;
        private Label LNombre;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button BSalir;
    }
}
