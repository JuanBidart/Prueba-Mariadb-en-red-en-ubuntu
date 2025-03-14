using controlador;


namespace appPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            ConexionControl conexionControl = new ConexionControl();

            lblResultadook.Text = conexionControl.ProbarConexion();
        }
    }
}
