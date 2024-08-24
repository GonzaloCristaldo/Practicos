namespace practico3
{
    partial class Pequeño_formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pequeño_formulario));
            TGuardar = new Button();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            LNya = new Label();
            LModificar = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TEliminar = new Button();
            panel1 = new Panel();
            Ttel = new TextBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            TSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TGuardar
            // 
            TGuardar.Image = (Image)resources.GetObject("TGuardar.Image");
            TGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            TGuardar.Location = new Point(34, 525);
            TGuardar.Margin = new Padding(3, 4, 3, 4);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(120, 77);
            TGuardar.TabIndex = 0;
            TGuardar.Text = "Guardar";
            TGuardar.TextAlign = ContentAlignment.MiddleRight;
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += button1_Click;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.BackColor = SystemColors.ControlDark;
            LDni.Location = new Point(16, 81);
            LDni.Name = "LDni";
            LDni.Size = new Size(32, 20);
            LDni.TabIndex = 1;
            LDni.Text = "Dni";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.BackColor = SystemColors.ControlDark;
            LApellido.Location = new Point(14, 127);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(66, 20);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.BackColor = SystemColors.ControlDark;
            LNombre.Location = new Point(16, 187);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(64, 20);
            LNombre.TabIndex = 3;
            LNombre.Text = "Nombre";
            LNombre.Click += LNombre_Click;
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.BackColor = SystemColors.ControlDark;
            LNya.Location = new Point(16, 11);
            LNya.Name = "LNya";
            LNya.Size = new Size(139, 20);
            LNya.TabIndex = 4;
            LNya.Text = "Nombre y Apellido:";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = SystemColors.ControlDark;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(186, 84);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(73, 20);
            LModificar.TabIndex = 5;
            LModificar.Text = "modificar";
            LModificar.Click += LModificar_Click;
            // 
            // TDni
            // 
            TDni.Location = new Point(136, 151);
            TDni.Margin = new Padding(3, 4, 3, 4);
            TDni.Name = "TDni";
            TDni.Size = new Size(135, 27);
            TDni.TabIndex = 6;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(136, 200);
            TApellido.Margin = new Padding(3, 4, 3, 4);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(135, 27);
            TApellido.TabIndex = 7;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(136, 257);
            TNombre.Margin = new Padding(3, 4, 3, 4);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(135, 27);
            TNombre.TabIndex = 8;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TEliminar
            // 
            TEliminar.Image = (Image)resources.GetObject("TEliminar.Image");
            TEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            TEliminar.Location = new Point(186, 525);
            TEliminar.Margin = new Padding(3, 4, 3, 4);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(121, 77);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.TextAlign = ContentAlignment.MiddleRight;
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(Ttel);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LNya);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(34, 73);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 385);
            panel1.TabIndex = 10;
            // 
            // Ttel
            // 
            Ttel.Location = new Point(102, 233);
            Ttel.Margin = new Padding(3, 4, 3, 4);
            Ttel.Name = "Ttel";
            Ttel.Size = new Size(135, 27);
            Ttel.TabIndex = 15;
            Ttel.TextChanged += Ttel_TextChanged;
            Ttel.KeyPress += Ttel_KeyPress;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(142, 344);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(105, 24);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Mastercard";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(143, 311);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(58, 24);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "Visa";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(143, 279);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Naranja";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 279);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 12;
            label2.Text = "Tarjeta de creditos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 233);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 11;
            label1.Text = "Telefono";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(197, 12);
            label3.Name = "label3";
            label3.Size = new Size(173, 30);
            label3.TabIndex = 11;
            label3.Text = "Nuevo Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources._2922506;
            pictureBox1.Image = Properties.Resources._2922506;
            pictureBox1.Location = new Point(371, 73);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(371, 316);
            RBVaron.Margin = new Padding(3, 4, 3, 4);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(68, 24);
            RBVaron.TabIndex = 13;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(445, 316);
            RBMujer.Margin = new Padding(3, 4, 3, 4);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(68, 24);
            RBMujer.TabIndex = 14;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // TSalir
            // 
            TSalir.Image = (Image)resources.GetObject("TSalir.Image");
            TSalir.ImageAlign = ContentAlignment.MiddleLeft;
            TSalir.Location = new Point(411, 525);
            TSalir.Margin = new Padding(3, 4, 3, 4);
            TSalir.Name = "TSalir";
            TSalir.Size = new Size(121, 77);
            TSalir.TabIndex = 15;
            TSalir.Text = "Salir";
            TSalir.TextAlign = ContentAlignment.MiddleRight;
            TSalir.UseVisualStyleBackColor = true;
            TSalir.Click += TSalir_Click;
            // 
            // Pequeño_formulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 635);
            Controls.Add(pictureBox1);
            Controls.Add(TSalir);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(label3);
            Controls.Add(TEliminar);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(LModificar);
            Controls.Add(TGuardar);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Pequeño_formulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pequeño formulario";
            Load += Pequeño_formulario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TGuardar;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private Label LNya;
        private Label LModificar;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button TEliminar;
        private Panel panel1;
        private Label label1;
        private TextBox Ttel;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private Button TSalir;
    }
}