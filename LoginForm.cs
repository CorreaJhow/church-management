using church_management_system.Data;

namespace church_management_system
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black; 
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                txtUser.Text = "Usuario"; 
                txtUser.ForeColor = Color.Gray; 
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Senha")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*'; 
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Senha";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.PasswordChar = '\0'; 
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Usuario";
            txtUser.ForeColor = Color.Gray;

            txtPassword.Text = "Senha";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.PasswordChar = '\0';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuarioValido = ValidaUsuario();
            var senhaValida = ValidaSenha();

            if (!usuarioValido || !senhaValida)
            {
                return; 
            }

            if (!AutenticaUsuario(txtUser.Text, txtPassword.Text))
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Aqui você pode redirecionar para outra janela, por exemplo:
            // this.Hide();
            // new MainForm().ShowDialog();
            // this.Close();
        }

        private bool ValidaUsuario()
        {
            string usuario = txtUser.Text;

            if (string.IsNullOrEmpty(usuario))
            {
                ExibeErro("O campo Usuário deve ser preenchido.", txtUser);
                return false;
            }

            return true;
        }

        private bool ValidaSenha()
        {
            string senha = txtPassword.Text;

            if (string.IsNullOrEmpty(senha))
            {
                ExibeErro("O campo Senha deve ser preenchido.", txtPassword);
                return false;
            }

            return true; 
        }

        private void ExibeErro(string mensagem, Control controle)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            controle.Focus();
        }

        private bool AutenticaUsuario(string usuario, string senha)
        {
            using (var context = new DataContext())
            {
                return context.Users.Any(u => u.Nome == usuario && u.Senha == senha);
            }
        }
    }
}
