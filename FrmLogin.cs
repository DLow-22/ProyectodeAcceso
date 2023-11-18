namespace Proyectologin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtcontrasena.Clear();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text == "Usuario" && txtcontrasena.Text == "admin")
            {
                Frminicio frmInicio = new Frminicio();
                this.Hide();
                frmInicio.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtusuario.Clear();
                txtcontrasena.Clear();
            }
        }
    }
}
