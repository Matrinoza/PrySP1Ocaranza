namespace sp1Ocaranza
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int intentos = 0;
        private void bntAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administrador" &&
                txtContraseña.Text == "Kamerun") ||
                (txtUsuario.Text == "Operador" &&
                txtContraseña.Text == "operando"))
            {
            else
                {
                    MessageBox.Show("No es esta");
                    intentos++;
                    if (intentos == 3)
                    {
                        this.Close();
                    }
                }
            }
        }
        private void bntCancelar_Click(object sender, EventArgs e)
            {
            this.Close();
        }
    }
}