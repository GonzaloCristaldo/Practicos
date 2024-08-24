namespace Practico1;

public partial class Practico1 : Form
{


    public Practico1()
    {
        InitializeComponent();
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void LNombre_Click(object sender, EventArgs e)
    {

    }

    private void BGuardar_Click(object sender, EventArgs e)
    {
        TApellidoYnombre.Text = TApellido.Text + " " + TNombre.Text;

    }

    private void BEliminar_Click(object sender, EventArgs e)
    {
        TApellidoYnombre.Clear();
    }

    private void TApellidoYnombre_TextChanged(object sender, EventArgs e)
    {

    }

    private void BSalir_Click(object sender, EventArgs e)
    {
        Application.Exit();

    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.S)
        {
            this.Close();
        }
    }


}
