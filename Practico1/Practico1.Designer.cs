namespace Practico1;

partial class Practico1
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
        LNombre = new Label();
        TNombre = new TextBox();
        TApellido = new TextBox();
        LApellido = new Label();
        TApellidoYnombre = new TextBox();
        BSalir = new Button();
        BGuardar = new Button();
        BEliminar = new Button();
        SuspendLayout();
        // 
        // LNombre
        // 
        LNombre.AutoSize = true;
        LNombre.Location = new Point(60, 62);
        LNombre.Name = "LNombre";
        LNombre.Size = new Size(64, 20);
        LNombre.TabIndex = 3;
        LNombre.Text = "Nombre";
        LNombre.Click += LNombre_Click;
        // 
        // TNombre
        // 
        TNombre.Location = new Point(146, 62);
        TNombre.Margin = new Padding(3, 4, 3, 4);
        TNombre.Name = "TNombre";
        TNombre.Size = new Size(114, 27);
        TNombre.TabIndex = 5;
        // 
        // TApellido
        // 
        TApellido.Location = new Point(146, 128);
        TApellido.Margin = new Padding(3, 4, 3, 4);
        TApellido.Name = "TApellido";
        TApellido.Size = new Size(114, 27);
        TApellido.TabIndex = 6;
        // 
        // LApellido
        // 
        LApellido.AutoSize = true;
        LApellido.Location = new Point(60, 131);
        LApellido.Name = "LApellido";
        LApellido.Size = new Size(66, 20);
        LApellido.TabIndex = 7;
        LApellido.Text = "Apellido";
        // 
        // TApellidoYnombre
        // 
        TApellidoYnombre.BackColor = SystemColors.InactiveCaption;
        TApellidoYnombre.Location = new Point(295, 13);
        TApellidoYnombre.Margin = new Padding(3, 4, 3, 4);
        TApellidoYnombre.Multiline = true;
        TApellidoYnombre.Name = "TApellidoYnombre";
        TApellidoYnombre.Size = new Size(175, 156);
        TApellidoYnombre.TabIndex = 8;
        TApellidoYnombre.TextChanged += TApellidoYnombre_TextChanged;
        // 
        // BSalir
        // 
        BSalir.BackColor = Color.DarkGoldenrod;
        BSalir.FlatAppearance.BorderColor = Color.Red;
        BSalir.FlatStyle = FlatStyle.Popup;
        BSalir.Location = new Point(384, 184);
        BSalir.Margin = new Padding(3, 4, 3, 4);
        BSalir.Name = "BSalir";
        BSalir.Size = new Size(86, 31);
        BSalir.TabIndex = 9;
        BSalir.Text = "Salir";
        BSalir.UseVisualStyleBackColor = false;
        BSalir.Click += BSalir_Click;
        // 
        // BGuardar
        // 
        BGuardar.BackColor = Color.MintCream;
        BGuardar.FlatStyle = FlatStyle.Popup;
        BGuardar.Location = new Point(60, 184);
        BGuardar.Margin = new Padding(3, 4, 3, 4);
        BGuardar.Name = "BGuardar";
        BGuardar.Size = new Size(86, 31);
        BGuardar.TabIndex = 10;
        BGuardar.Text = "Guardar";
        BGuardar.UseVisualStyleBackColor = false;
        BGuardar.Click += BGuardar_Click;
        // 
        // BEliminar
        // 
        BEliminar.BackColor = Color.RosyBrown;
        BEliminar.FlatStyle = FlatStyle.Popup;
        BEliminar.Location = new Point(174, 184);
        BEliminar.Margin = new Padding(3, 4, 3, 4);
        BEliminar.Name = "BEliminar";
        BEliminar.Size = new Size(86, 31);
        BEliminar.TabIndex = 11;
        BEliminar.Text = "Eliminar";
        BEliminar.UseVisualStyleBackColor = false;
        BEliminar.Click += BEliminar_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(482, 253);
        Controls.Add(BEliminar);
        Controls.Add(BGuardar);
        Controls.Add(BSalir);
        Controls.Add(TApellidoYnombre);
        Controls.Add(LApellido);
        Controls.Add(TApellido);
        Controls.Add(TNombre);
        Controls.Add(LNombre);
        KeyPreview = true;
        Name = "Form1";
        Text = "Mi primer Forms";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label LNombre;
    private TextBox TNombre;
    private TextBox TApellido;
    private Label LApellido;
    private TextBox TApellidoYnombre;
    private Button BSalir;
    private Button BGuardar;
    private Button BEliminar;
}
