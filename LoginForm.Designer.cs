namespace church_management_system
{
    partial class LoginForm
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
            pnlTopo = new Panel();
            lblTitle = new Label();
            pnlEsquerda = new Panel();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            pnlLogin = new Panel();
            lblEsqueceSenha = new Label();
            Cadastrar = new Label();
            pnlConteudo = new Panel();
            pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLogin.SuspendLayout();
            pnlConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(24, 43, 49);
            pnlTopo.Controls.Add(lblTitle);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(1000, 55);
            pnlTopo.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.Location = new Point(316, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(412, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "CMS | Church Management System";
            // 
            // pnlEsquerda
            // 
            pnlEsquerda.BackColor = Color.FromArgb(30, 58, 70);
            pnlEsquerda.Dock = DockStyle.Left;
            pnlEsquerda.Location = new Point(0, 55);
            pnlEsquerda.Name = "pnlEsquerda";
            pnlEsquerda.Size = new Size(129, 545);
            pnlEsquerda.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.WhiteSmoke;
            txtUser.Location = new Point(95, 183);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(175, 23);
            txtUser.TabIndex = 3;
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(95, 212);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(175, 23);
            txtPassword.TabIndex = 3;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(181, 195, 204);
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(95, 252);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(175, 38);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(121, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(89, 113, 125);
            pnlLogin.BackgroundImageLayout = ImageLayout.None;
            pnlLogin.BorderStyle = BorderStyle.FixedSingle;
            pnlLogin.Controls.Add(lblEsqueceSenha);
            pnlLogin.Controls.Add(Cadastrar);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(txtUser);
            pnlLogin.Location = new Point(250, 89);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(370, 367);
            pnlLogin.TabIndex = 4;
            // 
            // lblEsqueceSenha
            // 
            lblEsqueceSenha.AutoSize = true;
            lblEsqueceSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEsqueceSenha.Location = new Point(124, 327);
            lblEsqueceSenha.Name = "lblEsqueceSenha";
            lblEsqueceSenha.Size = new Size(120, 15);
            lblEsqueceSenha.TabIndex = 5;
            lblEsqueceSenha.Text = "Esqueci minha senha";
            // 
            // Cadastrar
            // 
            Cadastrar.AutoSize = true;
            Cadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cadastrar.Location = new Point(148, 302);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(72, 15);
            Cadastrar.TabIndex = 5;
            Cadastrar.Text = "Cadastre-se";
            // 
            // pnlConteudo
            // 
            pnlConteudo.AutoSize = true;
            pnlConteudo.BackColor = Color.FromArgb(244, 254, 255);
            pnlConteudo.Controls.Add(pnlLogin);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(129, 55);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(871, 545);
            pnlConteudo.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlEsquerda);
            Controls.Add(pnlTopo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "Login - CMS";
            Load += LoginForm_Load;
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlConteudo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTopo;
        private Panel pnlEsquerda;
        private Label lblTitle;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Panel pnlLogin;
        private Panel pnlConteudo;
        private Label lblEsqueceSenha;
        private Label Cadastrar;
    }
}
