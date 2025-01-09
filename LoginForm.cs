namespace church_management_system
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "User...")
            {
                txtUser.Text = ""; // Clear the placeholder
                txtUser.ForeColor = Color.Black; // Change the text color
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                txtUser.Text = "User..."; // Restores the placeholder
                txtUser.ForeColor = Color.Gray; // Change the text color
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*'; // Enables password character
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Password...";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.PasswordChar = '\0'; // Disables password character initially
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUser.Text = "User";
            txtUser.ForeColor = Color.Gray;

            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.PasswordChar = '\0'; // Disables password character initially
        }
    }
}
