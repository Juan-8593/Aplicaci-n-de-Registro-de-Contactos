namespace WinFormsApp1
{
    partial class Form1
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
            LabelNombre = new Label();
            LabelCorreo = new Label();
            LabelTelefono = new Label();
            TextNombre = new TextBox();
            TextTelefono = new TextBox();
            TextCorreo = new TextBox();
            listBox1 = new ListBox();
            BotonAceptar = new Button();
            BotonLimpiar = new Button();
            BotonLimpiarDirectorio = new Button();
            LabelDirectorio = new Label();
            label1 = new Label();
            LabelConfirmacion = new Label();
            SuspendLayout();
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new Point(89, 46);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(64, 20);
            LabelNombre.TabIndex = 0;
            LabelNombre.Text = "Nombre";
            // 
            // LabelCorreo
            // 
            LabelCorreo.AutoSize = true;
            LabelCorreo.Location = new Point(89, 225);
            LabelCorreo.Name = "LabelCorreo";
            LabelCorreo.Size = new Size(54, 20);
            LabelCorreo.TabIndex = 1;
            LabelCorreo.Text = "Correo";
            // 
            // LabelTelefono
            // 
            LabelTelefono.AutoSize = true;
            LabelTelefono.Location = new Point(86, 133);
            LabelTelefono.Name = "LabelTelefono";
            LabelTelefono.Size = new Size(67, 20);
            LabelTelefono.TabIndex = 2;
            LabelTelefono.Text = "Telefono";
            // 
            // TextNombre
            // 
            TextNombre.Location = new Point(89, 86);
            TextNombre.Name = "TextNombre";
            TextNombre.Size = new Size(260, 27);
            TextNombre.TabIndex = 3;
            TextNombre.TextChanged += TextNombre_TextChanged;
            // 
            // TextTelefono
            // 
            TextTelefono.Location = new Point(89, 173);
            TextTelefono.Name = "TextTelefono";
            TextTelefono.Size = new Size(260, 27);
            TextTelefono.TabIndex = 4;
            // 
            // TextCorreo
            // 
            TextCorreo.Location = new Point(89, 266);
            TextCorreo.Name = "TextCorreo";
            TextCorreo.Size = new Size(260, 27);
            TextCorreo.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(464, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(429, 204);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // BotonAceptar
            // 
            BotonAceptar.Location = new Point(89, 368);
            BotonAceptar.Name = "BotonAceptar";
            BotonAceptar.Size = new Size(94, 29);
            BotonAceptar.TabIndex = 7;
            BotonAceptar.Text = "Aceptar";
            BotonAceptar.UseVisualStyleBackColor = true;
            BotonAceptar.Click += BotonAceptar_Click;
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(255, 368);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(94, 29);
            BotonLimpiar.TabIndex = 8;
            BotonLimpiar.Text = "Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonLimpiarDirectorio
            // 
            BotonLimpiarDirectorio.Location = new Point(572, 368);
            BotonLimpiarDirectorio.Name = "BotonLimpiarDirectorio";
            BotonLimpiarDirectorio.Size = new Size(180, 29);
            BotonLimpiarDirectorio.TabIndex = 9;
            BotonLimpiarDirectorio.Text = "Limpiar Directorio";
            BotonLimpiarDirectorio.UseVisualStyleBackColor = true;
            BotonLimpiarDirectorio.Click += BotonLimpiarDirectorio_Click;
            // 
            // LabelDirectorio
            // 
            LabelDirectorio.AutoSize = true;
            LabelDirectorio.Location = new Point(464, 46);
            LabelDirectorio.Name = "LabelDirectorio";
            LabelDirectorio.Size = new Size(76, 20);
            LabelDirectorio.TabIndex = 10;
            LabelDirectorio.Text = "Directorio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // LabelConfirmacion
            // 
            LabelConfirmacion.AutoSize = true;
            LabelConfirmacion.ForeColor = Color.Red;
            LabelConfirmacion.Location = new Point(112, 327);
            LabelConfirmacion.Name = "LabelConfirmacion";
            LabelConfirmacion.Size = new Size(0, 20);
            LabelConfirmacion.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(943, 450);
            Controls.Add(LabelConfirmacion);
            Controls.Add(label1);
            Controls.Add(LabelDirectorio);
            Controls.Add(BotonLimpiarDirectorio);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonAceptar);
            Controls.Add(listBox1);
            Controls.Add(TextCorreo);
            Controls.Add(TextTelefono);
            Controls.Add(TextNombre);
            Controls.Add(LabelTelefono);
            Controls.Add(LabelCorreo);
            Controls.Add(LabelNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNombre;
        private Label LabelCorreo;
        private Label LabelTelefono;
        private TextBox TextNombre;
        private TextBox TextTelefono;
        private TextBox TextCorreo;
        private ListBox listBox1;
        private Button BotonAceptar;
        private Button BotonLimpiar;
        private Button BotonLimpiarDirectorio;
        private Label LabelDirectorio;
        private Label label1;
        private Label LabelConfirmacion;
    }
}
